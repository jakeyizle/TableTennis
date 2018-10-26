using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Views
{
    public interface IPerson
    {
        List<string> WinningPlayersText { get; set; }
        List<string> LosingPlayersText { get; set; }
        List<string> ScoreText { get; set; }
        List<string> SettingsText { get; set; }
        string RatingChange1 { get; set; }
        string RatingChange2 { get; set; }
        string RatingChange3 { get; set; }
        string RatingChange4 { get; set; }
        string NewRating1 { get; set; }
        string NewRating2 { get; set; }
        string NewRating3 { get; set; }
        string NewRating4 { get; set; }
        void load_tableData(DataTable table = null);
        string StatPlayerText { get; set; }
        List<string> ElevenPointStats { get; set; }
        List<String> TwentyOnePointStats { get; set; }
    }
}
