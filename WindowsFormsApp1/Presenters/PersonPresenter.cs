using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Views;
using WindowsFormsApp1.Models;
using Moserware.Skills;
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
            Match match = new Match(nameList, gameInfo, personView.ScoreText[0], personView.ScoreText[1]);

            var newSkills = TrueSkillCalculator.CalculateNewRatings(gameInfo, match.GetTeams(), 1, 2);


            //todo: sweet jesus fix
            if (nameList.Count == 2)
            {
                personView.RatingChange1 = Math.Round(match.People[0].UpdateRating(newSkills), 3).ToString();
                personView.RatingChange3 = Math.Round(match.People[1].UpdateRating(newSkills), 3).ToString();

                personView.NewRating1 = Math.Round(match.People[0].Rating().ConservativeRating, 3).ToString();
                personView.NewRating3 = Math.Round(match.People[1].Rating().ConservativeRating, 3).ToString();
            }
            else
            {
                personView.RatingChange1 = Math.Round(match.People[0].UpdateRating(newSkills), 3).ToString();
                personView.RatingChange2 = Math.Round(match.People[1].UpdateRating(newSkills), 3).ToString();
                personView.RatingChange3 = Math.Round(match.People[2].UpdateRating(newSkills), 3).ToString();
                personView.RatingChange4 = Math.Round(match.People[3].UpdateRating(newSkills), 3).ToString();

                personView.NewRating1 = Math.Round(match.People[0].Rating().ConservativeRating, 3).ToString();
                personView.NewRating2 = Math.Round(match.People[1].Rating().ConservativeRating, 3).ToString();
                personView.NewRating3 = Math.Round(match.People[2].Rating().ConservativeRating, 3).ToString();
                personView.NewRating4 = Math.Round(match.People[3].Rating().ConservativeRating, 3).ToString();
            }

        }
    }
}
