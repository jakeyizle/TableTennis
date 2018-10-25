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
    public class Match
    {
        [Key]
        public int MatchId { get; set; }
        public int? WinningScore { get; set; }
        public int? LosingScore { get; set; }
        public List<Person> People = new List<Person>();
        [NotMapped]
        static readonly TableTennisModel context = new TableTennisModel();
        [NotMapped]
        public GameInfo GameInfo;

        public virtual ICollection<MatchPerson> MatchPeople { get; set; }

        public Match(List<string> names, GameInfo gameInfo, string winningScore = null, string losingScore = null)
        {
            Save();
            foreach (string name in names)
            {
                Person person = new Person(name, gameInfo);
                People.Add(person);
                person.SetResult(names);                
                MatchPerson matchPerson = new MatchPerson(MatchId, person.PersonId, person.Result);
                matchPerson.Save();
            }
            if (winningScore != null && losingScore != null)
            {
                WinningScore = Int32.Parse(winningScore);
                LosingScore = Int32.Parse(losingScore);
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
                team.AddPlayer(person, person.Rating());
            }
            return team;
        }

        public IEnumerable<IDictionary<Player,Rating>> GetTeams()
        {
            return Teams.Concat(GetTeam((Result)1), GetTeam(0));
        }
    }
}
