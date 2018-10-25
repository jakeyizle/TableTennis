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
    }
}
