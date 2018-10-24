using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public virtual ICollection<MatchPerson> MatchPeople { get; set; }
        public Match()
        {

        }

        public Match(int winningScore, int losingScore)
        {
            WinningScore = winningScore;
            LosingScore = losingScore;
        }
    }
}
