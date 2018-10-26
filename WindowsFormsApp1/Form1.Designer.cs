namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWinPlayer1 = new System.Windows.Forms.TextBox();
            this.txtWinPlayer2 = new System.Windows.Forms.TextBox();
            this.txtWinPoints = new System.Windows.Forms.TextBox();
            this.txtLosePoints = new System.Windows.Forms.TextBox();
            this.txtLosePlayer2 = new System.Windows.Forms.TextBox();
            this.txtLosePlayer1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtScoreChangeWin2 = new System.Windows.Forms.TextBox();
            this.txtScoreChangeWin1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtScoreChangeLose2 = new System.Windows.Forms.TextBox();
            this.txtScoreChangeLose1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtNewRating4 = new System.Windows.Forms.TextBox();
            this.txtNewRating3 = new System.Windows.Forms.TextBox();
            this.txtNewRating2 = new System.Windows.Forms.TextBox();
            this.txtNewRating1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtPointsAgainst11 = new System.Windows.Forms.TextBox();
            this.txtPointsAgainst21 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtPoints11 = new System.Windows.Forms.TextBox();
            this.txtPoints21 = new System.Windows.Forms.TextBox();
            this.txtPointsLose11 = new System.Windows.Forms.TextBox();
            this.txtPointsLose21 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtPointsAgainstWin11 = new System.Windows.Forms.TextBox();
            this.txtPointsAgainstWin21 = new System.Windows.Forms.TextBox();
            this.txtWorstPlayerRecord21 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBestPlayerRecord21 = new System.Windows.Forms.TextBox();
            this.txtOverallRecord21 = new System.Windows.Forms.TextBox();
            this.txtWorstPlayerRecord11 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBestPlayerRecord11 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtOverallRecord11 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.peopleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTennisRankingsDataSet = new WindowsFormsApp1.TableTennisRankingsDataSet();
            this.peopleTableAdapter = new WindowsFormsApp1.TableTennisRankingsDataSetTableAdapters.PeopleTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTennisRankingsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit Match";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Points";
            // 
            // txtWinPlayer1
            // 
            this.txtWinPlayer1.Location = new System.Drawing.Point(236, 68);
            this.txtWinPlayer1.Name = "txtWinPlayer1";
            this.txtWinPlayer1.Size = new System.Drawing.Size(100, 20);
            this.txtWinPlayer1.TabIndex = 4;
            // 
            // txtWinPlayer2
            // 
            this.txtWinPlayer2.Location = new System.Drawing.Point(236, 94);
            this.txtWinPlayer2.Name = "txtWinPlayer2";
            this.txtWinPlayer2.Size = new System.Drawing.Size(100, 20);
            this.txtWinPlayer2.TabIndex = 5;
            // 
            // txtWinPoints
            // 
            this.txtWinPoints.Location = new System.Drawing.Point(236, 129);
            this.txtWinPoints.Name = "txtWinPoints";
            this.txtWinPoints.Size = new System.Drawing.Size(100, 20);
            this.txtWinPoints.TabIndex = 6;
            // 
            // txtLosePoints
            // 
            this.txtLosePoints.Location = new System.Drawing.Point(236, 256);
            this.txtLosePoints.Name = "txtLosePoints";
            this.txtLosePoints.Size = new System.Drawing.Size(100, 20);
            this.txtLosePoints.TabIndex = 12;
            // 
            // txtLosePlayer2
            // 
            this.txtLosePlayer2.Location = new System.Drawing.Point(236, 220);
            this.txtLosePlayer2.Name = "txtLosePlayer2";
            this.txtLosePlayer2.Size = new System.Drawing.Size(100, 20);
            this.txtLosePlayer2.TabIndex = 11;
            // 
            // txtLosePlayer1
            // 
            this.txtLosePlayer1.Location = new System.Drawing.Point(236, 194);
            this.txtLosePlayer1.Name = "txtLosePlayer1";
            this.txtLosePlayer1.Size = new System.Drawing.Size(100, 20);
            this.txtLosePlayer1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Points";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Player 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Player 1";
            // 
            // txtScoreChangeWin2
            // 
            this.txtScoreChangeWin2.Location = new System.Drawing.Point(474, 99);
            this.txtScoreChangeWin2.Name = "txtScoreChangeWin2";
            this.txtScoreChangeWin2.ReadOnly = true;
            this.txtScoreChangeWin2.Size = new System.Drawing.Size(100, 20);
            this.txtScoreChangeWin2.TabIndex = 16;
            // 
            // txtScoreChangeWin1
            // 
            this.txtScoreChangeWin1.Location = new System.Drawing.Point(474, 70);
            this.txtScoreChangeWin1.Name = "txtScoreChangeWin1";
            this.txtScoreChangeWin1.ReadOnly = true;
            this.txtScoreChangeWin1.Size = new System.Drawing.Size(100, 20);
            this.txtScoreChangeWin1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Rating Change";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "New Rating";
            // 
            // txtScoreChangeLose2
            // 
            this.txtScoreChangeLose2.Location = new System.Drawing.Point(474, 222);
            this.txtScoreChangeLose2.Name = "txtScoreChangeLose2";
            this.txtScoreChangeLose2.ReadOnly = true;
            this.txtScoreChangeLose2.Size = new System.Drawing.Size(100, 20);
            this.txtScoreChangeLose2.TabIndex = 20;
            // 
            // txtScoreChangeLose1
            // 
            this.txtScoreChangeLose1.Location = new System.Drawing.Point(474, 193);
            this.txtScoreChangeLose1.Name = "txtScoreChangeLose1";
            this.txtScoreChangeLose1.ReadOnly = true;
            this.txtScoreChangeLose1.Size = new System.Drawing.Size(100, 20);
            this.txtScoreChangeLose1.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Winning Team";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(593, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(45, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Losing Team";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(35, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(886, 534);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.textBox7);
            this.tabPage1.Controls.Add(this.textBox8);
            this.tabPage1.Controls.Add(this.txtNewRating4);
            this.tabPage1.Controls.Add(this.txtNewRating3);
            this.tabPage1.Controls.Add(this.txtNewRating2);
            this.tabPage1.Controls.Add(this.txtNewRating1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtScoreChangeLose2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtScoreChangeLose1);
            this.tabPage1.Controls.Add(this.txtWinPlayer1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtWinPlayer2);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtWinPoints);
            this.tabPage1.Controls.Add(this.txtScoreChangeWin2);
            this.tabPage1.Controls.Add(this.txtLosePlayer1);
            this.tabPage1.Controls.Add(this.txtScoreChangeWin1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtLosePoints);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtLosePlayer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(878, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(596, 222);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 29;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(596, 193);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 28;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(596, 99);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 27;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(596, 70);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 26;
            // 
            // txtNewRating4
            // 
            this.txtNewRating4.Location = new System.Drawing.Point(355, 222);
            this.txtNewRating4.Name = "txtNewRating4";
            this.txtNewRating4.ReadOnly = true;
            this.txtNewRating4.Size = new System.Drawing.Size(100, 20);
            this.txtNewRating4.TabIndex = 25;
            // 
            // txtNewRating3
            // 
            this.txtNewRating3.Location = new System.Drawing.Point(355, 193);
            this.txtNewRating3.Name = "txtNewRating3";
            this.txtNewRating3.ReadOnly = true;
            this.txtNewRating3.Size = new System.Drawing.Size(100, 20);
            this.txtNewRating3.TabIndex = 24;
            // 
            // txtNewRating2
            // 
            this.txtNewRating2.Location = new System.Drawing.Point(355, 99);
            this.txtNewRating2.Name = "txtNewRating2";
            this.txtNewRating2.ReadOnly = true;
            this.txtNewRating2.Size = new System.Drawing.Size(100, 20);
            this.txtNewRating2.TabIndex = 23;
            // 
            // txtNewRating1
            // 
            this.txtNewRating1.Location = new System.Drawing.Point(355, 70);
            this.txtNewRating1.Name = "txtNewRating1";
            this.txtNewRating1.ReadOnly = true;
            this.txtNewRating1.Size = new System.Drawing.Size(100, 20);
            this.txtNewRating1.TabIndex = 22;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(878, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(190, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 407);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtPointsAgainst11);
            this.tabPage3.Controls.Add(this.txtPointsAgainst21);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.txtPoints11);
            this.tabPage3.Controls.Add(this.txtPoints21);
            this.tabPage3.Controls.Add(this.txtPointsLose11);
            this.tabPage3.Controls.Add(this.txtPointsLose21);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.txtPointsAgainstWin11);
            this.tabPage3.Controls.Add(this.txtPointsAgainstWin21);
            this.tabPage3.Controls.Add(this.txtWorstPlayerRecord21);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.txtBestPlayerRecord21);
            this.tabPage3.Controls.Add(this.txtOverallRecord21);
            this.tabPage3.Controls.Add(this.txtWorstPlayerRecord11);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.txtBestPlayerRecord11);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.txtOverallRecord11);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(878, 508);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // txtPointsAgainst11
            // 
            this.txtPointsAgainst11.Location = new System.Drawing.Point(313, 240);
            this.txtPointsAgainst11.Name = "txtPointsAgainst11";
            this.txtPointsAgainst11.ReadOnly = true;
            this.txtPointsAgainst11.Size = new System.Drawing.Size(244, 20);
            this.txtPointsAgainst11.TabIndex = 24;
            this.txtPointsAgainst11.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // txtPointsAgainst21
            // 
            this.txtPointsAgainst21.Location = new System.Drawing.Point(605, 240);
            this.txtPointsAgainst21.Name = "txtPointsAgainst21";
            this.txtPointsAgainst21.ReadOnly = true;
            this.txtPointsAgainst21.Size = new System.Drawing.Size(245, 20);
            this.txtPointsAgainst21.TabIndex = 23;
            this.txtPointsAgainst21.TextChanged += new System.EventHandler(this.textBox16_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(167, 247);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(133, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "Avg Points Scored Against";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(167, 206);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(95, 13);
            this.label24.TabIndex = 21;
            this.label24.Text = "Avg Points Scored";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // txtPoints11
            // 
            this.txtPoints11.Location = new System.Drawing.Point(313, 199);
            this.txtPoints11.Name = "txtPoints11";
            this.txtPoints11.ReadOnly = true;
            this.txtPoints11.Size = new System.Drawing.Size(244, 20);
            this.txtPoints11.TabIndex = 20;
            this.txtPoints11.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            // 
            // txtPoints21
            // 
            this.txtPoints21.Location = new System.Drawing.Point(605, 199);
            this.txtPoints21.Name = "txtPoints21";
            this.txtPoints21.ReadOnly = true;
            this.txtPoints21.Size = new System.Drawing.Size(245, 20);
            this.txtPoints21.TabIndex = 19;
            this.txtPoints21.TextChanged += new System.EventHandler(this.textBox18_TextChanged);
            // 
            // txtPointsLose11
            // 
            this.txtPointsLose11.Location = new System.Drawing.Point(313, 323);
            this.txtPointsLose11.Name = "txtPointsLose11";
            this.txtPointsLose11.ReadOnly = true;
            this.txtPointsLose11.Size = new System.Drawing.Size(244, 20);
            this.txtPointsLose11.TabIndex = 18;
            // 
            // txtPointsLose21
            // 
            this.txtPointsLose21.Location = new System.Drawing.Point(605, 323);
            this.txtPointsLose21.Name = "txtPointsLose21";
            this.txtPointsLose21.ReadOnly = true;
            this.txtPointsLose21.Size = new System.Drawing.Size(245, 20);
            this.txtPointsLose21.TabIndex = 17;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(167, 330);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(102, 13);
            this.label22.TabIndex = 16;
            this.label22.Text = "Avg Points For Lose";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(167, 289);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(118, 13);
            this.label21.TabIndex = 15;
            this.label21.Text = "Avg Points Against Win";
            // 
            // txtPointsAgainstWin11
            // 
            this.txtPointsAgainstWin11.Location = new System.Drawing.Point(313, 282);
            this.txtPointsAgainstWin11.Name = "txtPointsAgainstWin11";
            this.txtPointsAgainstWin11.ReadOnly = true;
            this.txtPointsAgainstWin11.Size = new System.Drawing.Size(244, 20);
            this.txtPointsAgainstWin11.TabIndex = 14;
            // 
            // txtPointsAgainstWin21
            // 
            this.txtPointsAgainstWin21.Location = new System.Drawing.Point(605, 282);
            this.txtPointsAgainstWin21.Name = "txtPointsAgainstWin21";
            this.txtPointsAgainstWin21.ReadOnly = true;
            this.txtPointsAgainstWin21.Size = new System.Drawing.Size(245, 20);
            this.txtPointsAgainstWin21.TabIndex = 13;
            // 
            // txtWorstPlayerRecord21
            // 
            this.txtWorstPlayerRecord21.Location = new System.Drawing.Point(605, 166);
            this.txtWorstPlayerRecord21.Name = "txtWorstPlayerRecord21";
            this.txtWorstPlayerRecord21.ReadOnly = true;
            this.txtWorstPlayerRecord21.Size = new System.Drawing.Size(245, 20);
            this.txtWorstPlayerRecord21.TabIndex = 12;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(394, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 13);
            this.label20.TabIndex = 11;
            this.label20.Text = "11 point";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(708, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 10;
            this.label19.Text = "21 points";
            // 
            // txtBestPlayerRecord21
            // 
            this.txtBestPlayerRecord21.Location = new System.Drawing.Point(605, 125);
            this.txtBestPlayerRecord21.Name = "txtBestPlayerRecord21";
            this.txtBestPlayerRecord21.ReadOnly = true;
            this.txtBestPlayerRecord21.Size = new System.Drawing.Size(245, 20);
            this.txtBestPlayerRecord21.TabIndex = 9;
            // 
            // txtOverallRecord21
            // 
            this.txtOverallRecord21.Location = new System.Drawing.Point(605, 86);
            this.txtOverallRecord21.Name = "txtOverallRecord21";
            this.txtOverallRecord21.ReadOnly = true;
            this.txtOverallRecord21.Size = new System.Drawing.Size(245, 20);
            this.txtOverallRecord21.TabIndex = 8;
            // 
            // txtWorstPlayerRecord11
            // 
            this.txtWorstPlayerRecord11.Location = new System.Drawing.Point(313, 166);
            this.txtWorstPlayerRecord11.Name = "txtWorstPlayerRecord11";
            this.txtWorstPlayerRecord11.ReadOnly = true;
            this.txtWorstPlayerRecord11.Size = new System.Drawing.Size(244, 20);
            this.txtWorstPlayerRecord11.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(167, 169);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(111, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Worst Record Against";
            // 
            // txtBestPlayerRecord11
            // 
            this.txtBestPlayerRecord11.Location = new System.Drawing.Point(313, 125);
            this.txtBestPlayerRecord11.Name = "txtBestPlayerRecord11";
            this.txtBestPlayerRecord11.ReadOnly = true;
            this.txtBestPlayerRecord11.Size = new System.Drawing.Size(244, 20);
            this.txtBestPlayerRecord11.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(167, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Best Record Against (W-L)";
            // 
            // txtOverallRecord11
            // 
            this.txtOverallRecord11.Location = new System.Drawing.Point(313, 86);
            this.txtOverallRecord11.Name = "txtOverallRecord11";
            this.txtOverallRecord11.ReadOnly = true;
            this.txtOverallRecord11.Size = new System.Drawing.Size(244, 20);
            this.txtOverallRecord11.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(167, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Record W-L (W%)";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(31, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Player";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.peopleBindingSource, "Name", true));
            this.comboBox1.DataSource = this.peopleBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Name";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // peopleBindingSource
            // 
            this.peopleBindingSource.DataMember = "People";
            this.peopleBindingSource.DataSource = this.tableTennisRankingsDataSet;
            // 
            // tableTennisRankingsDataSet
            // 
            this.tableTennisRankingsDataSet.DataSetName = "TableTennisRankingsDataSet";
            this.tableTennisRankingsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peopleTableAdapter
            // 
            this.peopleTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 558);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTennisRankingsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWinPlayer1;
        private System.Windows.Forms.TextBox txtWinPlayer2;
        private System.Windows.Forms.TextBox txtWinPoints;
        private System.Windows.Forms.TextBox txtLosePoints;
        private System.Windows.Forms.TextBox txtLosePlayer2;
        private System.Windows.Forms.TextBox txtLosePlayer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtScoreChangeWin2;
        private System.Windows.Forms.TextBox txtScoreChangeWin1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtScoreChangeLose2;
        private System.Windows.Forms.TextBox txtScoreChangeLose1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox txtNewRating4;
        private System.Windows.Forms.TextBox txtNewRating3;
        private System.Windows.Forms.TextBox txtNewRating2;
        private System.Windows.Forms.TextBox txtNewRating1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboBox1;
        private TableTennisRankingsDataSet tableTennisRankingsDataSet;
        private System.Windows.Forms.BindingSource peopleBindingSource;
        private TableTennisRankingsDataSetTableAdapters.PeopleTableAdapter peopleTableAdapter;
        private System.Windows.Forms.TextBox txtOverallRecord11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPointsAgainst11;
        private System.Windows.Forms.TextBox txtPointsAgainst21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtPoints11;
        private System.Windows.Forms.TextBox txtPoints21;
        private System.Windows.Forms.TextBox txtPointsLose11;
        private System.Windows.Forms.TextBox txtPointsLose21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtPointsAgainstWin11;
        private System.Windows.Forms.TextBox txtPointsAgainstWin21;
        private System.Windows.Forms.TextBox txtWorstPlayerRecord21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtBestPlayerRecord21;
        private System.Windows.Forms.TextBox txtOverallRecord21;
        private System.Windows.Forms.TextBox txtWorstPlayerRecord11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBestPlayerRecord11;
        private System.Windows.Forms.Label label17;
    }
}

