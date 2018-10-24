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

        
        private void button1_Click(object sender, EventArgs e)
        {
            PersonPresenter presenter = new PersonPresenter(this);
            presenter.CalculateRatingChange();
        }
    }
}
