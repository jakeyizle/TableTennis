using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moserware.Skills;

namespace WindowsFormsApp1.Models
{
    public enum PointType
    {
        ElevenPoints,
        TwentyOnePoints,
        Null,
    }
    public class Match
    {
        [Key]
        public int MatchId { get; set; }
        public int? WinningScore { get; set; }
        public int? LosingScore { get; set; }
        public PointType PointType { get; set; }
        public List<Person> People = new List<Person>();
        [NotMapped]
        static readonly TableTennisModel context = new TableTennisModel();
        [NotMapped]
        public GameInfo GameInfo;

        public virtual ICollection<MatchPerson> MatchPeople { get; set; }

        public Match()
        {

        }
        public Match(List<string> names, GameInfo gameInfo, List<string> scoreText)
        {
            if (scoreText.Any())
            {
                WinningScore = Int32.Parse(scoreText[0]);
                LosingScore = Int32.Parse(scoreText[1]);
                if (WinningScore >= 21)
                {
                    PointType = PointType.TwentyOnePoints;
                }
                else
                {
                    PointType = PointType.ElevenPoints;
                }
            }
            else
            {
                PointType = PointType.Null;
            }
            Save();
            foreach (string name in names)
            {
                Person person = new Person(name, gameInfo);
                People.Add(person);
                person.SetResult(names);                
                MatchPerson matchPerson = new MatchPerson(MatchId, person.PersonId, person.Result);
                matchPerson.Save();
            }
        }

        public void Save()
        {
            context.Matches.Add(this);
            context.SaveChanges();
        }
     
        Team GetTeam(Result result)
        {
            Team team = new Team();
            var list = People.Where(x => x.Result == result).ToList();
            foreach (Person person in list)
            {
                team.AddPlayer(person, person.Rating);
            }
            return team;
        }

        public IEnumerable<IDictionary<Player,Rating>> GetTeams()
        {
            return Teams.Concat(GetTeam((Result)1), GetTeam(0));
        }
    }
}
