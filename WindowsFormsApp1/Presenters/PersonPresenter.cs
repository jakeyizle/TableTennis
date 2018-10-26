using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Views;
using WindowsFormsApp1.Models;
using Moserware.Skills;
using System.Data;
using FastMember;

namespace WindowsFormsApp1.Presenters
{
    public class PersonPresenter
    {
        IPerson personView;

        public PersonPresenter(IPerson view)
        {
            personView = view;
        }

        public void CalculateRatingChange()
        {
            List<string> nameList = personView.WinningPlayersText.Concat(personView.LosingPlayersText).ToList();
            nameList = nameList.Where(x => !string.IsNullOrWhiteSpace(x)).ToList();

            var settings = personView.SettingsText.Where(x => !string.IsNullOrWhiteSpace(x)).ToList();

            var gameInfo = GameInfo.DefaultGameInfo;
            Match match = new Match(nameList, gameInfo, personView.ScoreText.Where(x => !string.IsNullOrWhiteSpace(x)).ToList());
            

            var newSkills = TrueSkillCalculator.CalculateNewRatings(gameInfo, match.GetTeams(), 1, 2);


            //todo: sweet jesus fix
            if (nameList.Count == 2)
            {
                personView.RatingChange1 = Math.Round(match.People[0].UpdateRating(newSkills), 3).ToString();
                personView.RatingChange3 = Math.Round(match.People[1].UpdateRating(newSkills), 3).ToString();

                personView.NewRating1 = Math.Round(match.People[0].Rating.ConservativeRating, 3).ToString();
                personView.NewRating3 = Math.Round(match.People[1].Rating.ConservativeRating, 3).ToString();
            }
            else
            {
                personView.RatingChange1 = Math.Round(match.People[0].UpdateRating(newSkills), 3).ToString();
                personView.RatingChange2 = Math.Round(match.People[1].UpdateRating(newSkills), 3).ToString();
                personView.RatingChange3 = Math.Round(match.People[2].UpdateRating(newSkills), 3).ToString();
                personView.RatingChange4 = Math.Round(match.People[3].UpdateRating(newSkills), 3).ToString();

                personView.NewRating1 = Math.Round(match.People[0].Rating.ConservativeRating, 3).ToString();
                personView.NewRating2 = Math.Round(match.People[1].Rating.ConservativeRating, 3).ToString();
                personView.NewRating3 = Math.Round(match.People[2].Rating.ConservativeRating, 3).ToString();
                personView.NewRating4 = Math.Round(match.People[3].Rating.ConservativeRating, 3).ToString();
            }
        }

        public void load_tableData()
        {
            using (var context = new TableTennisModel())
            {
                var people = context.People.ToList();
                people = people.OrderByDescending(x => x.ConservativeRating).ToList();
                people.ToList().ForEach(x =>
                {
                    x.Rank = people.IndexOf(x) + 1;
                    x.GamesPlayed = context.MatchPeople.Where(y => y.PersonId == x.PersonId).Count();
                    var matchesWon = context.MatchPeople.Where(z => z.PersonId == x.PersonId && z.MatchResult == Result.Win).Count();
                    x.WinPercentage = Math.Round((double)matchesWon / x.GamesPlayed * 100,3);
                });

                DataTable table = new DataTable();
                using (var reader = ObjectReader.Create(people, "Rank", "ConservativeRating", "Name", "GamesPlayed", "WinPercentage"))
                {
                    table.Load(reader);
                }
                personView.load_tableData(table);
            }
        }

        public void load_personStats()
        {
            string name = personView.StatPlayerText;
            Statistic statistic = new Statistic(name);
            List<string> elevenList = new List<string>
            {             
                statistic.Record(PointType.ElevenPoints),
                statistic.BestOrWorstRecord(Result.Win, PointType.ElevenPoints),
                statistic.BestOrWorstRecord(Result.Loss, PointType.ElevenPoints),
                statistic.AveragePointsForOrAgainst(Result.Win, PointType.ElevenPoints),
                statistic.AveragePointsForOrAgainst(Result.Loss, PointType.ElevenPoints)
            };
            List<string> twentyOneList = new List<string>
            {
                statistic.Record(PointType.TwentyOnePoints),
                statistic.BestOrWorstRecord(Result.Win, PointType.TwentyOnePoints),
                statistic.BestOrWorstRecord(Result.Loss, PointType.TwentyOnePoints),
                statistic.AveragePointsForOrAgainst(Result.Win, PointType.TwentyOnePoints),
                statistic.AveragePointsForOrAgainst(Result.Loss, PointType.TwentyOnePoints)
            };
            personView.ElevenPointStats = elevenList;
            personView.TwentyOnePointStats = twentyOneList;
        }
    }
}
