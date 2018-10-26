using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Views;
using WindowsFormsApp1.Presenters;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form, IPerson
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<string> WinningPlayersText
        {
            get
            {
                return new List<string> { txtWinPlayer1.Text, txtWinPlayer2.Text };
            }
            set
            {
                WinningPlayersText = value;
            }
        }
        public List<string> LosingPlayersText
        {
            get
            {
                return new List<string> { txtLosePlayer1.Text, txtLosePlayer2.Text };
            }
            set
            {
                LosingPlayersText = value;
            }
        }
        public List<string> ScoreText
        {
            get
            {
                return new List<string> { txtWinPoints.Text, txtLosePoints.Text };
            }
            set
            {
                ScoreText = value;
            }
        }
        public string RatingChange1
        {
            get
            {
                return txtScoreChangeWin1.Text;
            }
            set
            {
                txtScoreChangeWin1.Text = value;
            }
        }
        public string RatingChange2
        {
            get
            {
                return txtScoreChangeWin2.Text;
            }
            set
            {
                txtScoreChangeWin2.Text = value;
            }
        }
        public string RatingChange3
        {
            get
            {
                return txtScoreChangeLose1.Text;
            }
            set
            {
                txtScoreChangeLose1.Text = value;
            }
        }

        public string RatingChange4
        {
            get
            {
                return txtScoreChangeLose2.Text;
            }
            set
            {
                txtScoreChangeLose2.Text = value;
            }
        }

        public string NewRating1
        {
            get
            {
                return txtNewRating1.Text;
            }
            set
            {
                txtNewRating1.Text = value;
            }
        }
        public string NewRating2
        {
            get
            {
                return txtNewRating2.Text;
            }
            set
            {
                txtNewRating2.Text = value;
            }
        }
        public string NewRating3
        {
            get
            {
                return txtNewRating3.Text;
            }
            set
            {
                txtNewRating3.Text = value;
            }
        }
        public string NewRating4
        {
            get
            {
                return txtNewRating4.Text;
            }
            set
            {
                txtNewRating4.Text = value;
            }
        }
        public string StatPlayerText
        {
            get
            {
                return comboBox1.Text;
            }
            set
            {
                comboBox1.Text = value;
            }
        }
        public List<string> SettingsText
        {
            get
            {
                return new List<string> { txtInitialMean.Text, txtDrawProbability.Text };
            }
            set
            {
                SettingsText = value;
            }
        }

        public List<string> ElevenPointStats
        {
            get
            {
                ElevenPointStats[0] = txtOverallRecord11.Text;
                ElevenPointStats[1] = txtBestPlayerRecord11.Text;
                ElevenPointStats[2] = txtWorstPlayerRecord11.Text;
                ElevenPointStats[3] = txtPoints11.Text;
                ElevenPointStats[4] = txtPointsAgainst11.Text;
                return ElevenPointStats;
            }
            set
            {
               txtOverallRecord11.Text = value[0];
               txtBestPlayerRecord11.Text = value[1];
               txtWorstPlayerRecord11.Text = value[2]; 
               txtPoints11.Text = value[3]; 
               txtPointsAgainst11.Text = value[4]; 
            }
        }
        public List<string> TwentyOnePointStats
        {
            get
            {
                TwentyOnePointStats[0] = txtOverallRecord21.Text;
                TwentyOnePointStats[1] = txtBestPlayerRecord21.Text;
                TwentyOnePointStats[2] = txtWorstPlayerRecord21.Text;
                TwentyOnePointStats[3] = txtPoints21.Text;
                TwentyOnePointStats[4] = txtPointsAgainst21.Text;
                return TwentyOnePointStats;
            }
            set
            {
                txtOverallRecord21.Text = value[0];
                txtBestPlayerRecord21.Text = value[1];
                txtWorstPlayerRecord21.Text = value[2];
                txtPoints21.Text = value[3];
                txtPointsAgainst21.Text = value[4];
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            PersonPresenter presenter = new PersonPresenter(this);
            presenter.CalculateRatingChange();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtInitialMean_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            PersonPresenter presenter = new PersonPresenter(this);
            presenter.load_tableData();
        }

        public void load_tableData(DataTable table)
        {
            BindingSource binding = new BindingSource();
            binding.DataSource = table;
            dataGridView1.DataSource = binding;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonPresenter presenter = new PersonPresenter(this);
            presenter.load_personStats();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tableTennisRankingsDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.tableTennisRankingsDataSet.People);

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
