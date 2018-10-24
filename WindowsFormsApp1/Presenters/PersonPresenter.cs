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
            using (var context = new TableTennisModel())
            {
                Team winningTeam = new Team();
                Team losingTeam = new Team();
                List<Person> personList = new List<Person>();

                Match match = new Match(Int32.Parse(personView.ScoreText[0]), Int32.Parse(personView.ScoreText[1]));
                context.Matches.Add(match);
                context.SaveChanges();

                foreach (string name in personView.WinningPlayersText)
                {
                    Person person = new Person(name);
                    winningTeam.AddPlayer(person, person.Rating());
                    personList.Add(person);
                    MatchPerson matchPerson = new MatchPerson(match.MatchId, person.PersonId, 1);
                    context.MatchPeople.Add(matchPerson);
                    context.SaveChanges();
                }

                foreach (string name in personView.LosingPlayersText)
                {
                    Person person = new Person(name);
                    losingTeam.AddPlayer(person, person.Rating());
                    personList.Add(person);
                    MatchPerson matchPerson = new MatchPerson(match.MatchId, person.PersonId, 0);
                    context.MatchPeople.Add(matchPerson);
                    context.SaveChanges();
                }


                foreach (Person person in personList)
                {
                }

                var newSkills = TrueSkillCalculator.CalculateNewRatings(GameInfo.DefaultGameInfo, Teams.Concat(winningTeam, losingTeam), 1, 2);
                //todo: sweet jesus fix
                personView.RatingChange1 = personList[0].UpdateRating(newSkills).ToString();
                personView.RatingChange2 = personList[1].UpdateRating(newSkills).ToString();
                personView.RatingChange3 = personList[2].UpdateRating(newSkills).ToString();
                personView.RatingChange4 = personList[3].UpdateRating(newSkills).ToString();
            }
        }
    }
}
