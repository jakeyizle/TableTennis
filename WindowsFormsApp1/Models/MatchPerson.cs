using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp1.Models
{
    public enum Result
    {
        Loss,
        Win
    }

    public class MatchPerson
    {
        [Key, Column(Order = 0)]
        public int MatchId { get; set;}
        [Key, Column(Order = 1)]
        public int PersonId { get; set; }

        public virtual Match Match { get; set; }
        public virtual Person Person { get; set; }

        public Result MatchResult { get; set; }
        [NotMapped]
        static readonly TableTennisModel context = new TableTennisModel();

        public MatchPerson(int matchId, int personId, Result result)
        {
            MatchId = matchId;
            PersonId = personId;
            MatchResult = result;
        }

        public void Save()
        {
            context.MatchPeople.Add(this);
            context.SaveChanges();
        }
    }
}
