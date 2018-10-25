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
            Match match = new Match(nameList, personView.ScoreText[0], personView.ScoreText[1]);
            var newSkills = TrueSkillCalculator.CalculateNewRatings(GameInfo.DefaultGameInfo, match.GetTeams(), 1, 2);
            //todo: sweet jesus fix
            personView.RatingChange1 = match.People[0].UpdateRating(newSkills).ToString();
            personView.RatingChange2 = match.People[1].UpdateRating(newSkills).ToString();
            personView.RatingChange3 = match.People[2].UpdateRating(newSkills).ToString();
            personView.RatingChange4 = match.People[3].UpdateRating(newSkills).ToString();
        }
    }
}
