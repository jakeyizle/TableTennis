using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Views
{
    public interface IPerson
    {
        List<string> WinningPlayersText { get; set; }
        List<string> LosingPlayersText { get; set; }
        List<string> ScoreText { get; set; }
        string RatingChange1 { get; set; }
        string RatingChange2 { get; set; }
        string RatingChange3 { get; set; }
        string RatingChange4 { get; set; }
    }
}
