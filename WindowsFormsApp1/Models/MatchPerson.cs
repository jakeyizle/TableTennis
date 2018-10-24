using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp1.Models
{
    public class MatchPerson
    {
        public enum Result
        {
            Loss,
            Win
        }

        [Key, Column(Order = 0)]
        public int MatchId { get; set;}
        [Key, Column(Order = 1)]
        public int PersonId { get; set; }

        public virtual Match Match { get; set; }
        public virtual Person Person { get; set; }

        public Result MatchResult { get; set; }

        public MatchPerson(int matchId, int personId, int result)
        {
            MatchId = matchId;
            PersonId = personId;
            MatchResult = (Result)result;
        }
    }
}
