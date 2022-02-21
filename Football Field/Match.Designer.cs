
namespace Football_Field
{
    partial class Match
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
            this.label2 = new System.Windows.Forms.Label();
            this.TeamName1 = new System.Windows.Forms.ComboBox();
            this.datagrip = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Search1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VS = new System.Windows.Forms.ComboBox();
            this.Team2Id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.IdTeam1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.PlayArea = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.PlayDate = new System.Windows.Forms.DateTimePicker();
            this.TeamName2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrip)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "FirstTeam";
            // 
            // TeamName1
            // 
            this.TeamName1.FormattingEnabled = true;
            this.TeamName1.Items.AddRange(new object[] {
            "Manchester City",
            "Manchester United",
            "Liverpool FC",
            "Lids United",
            "Bayern MünchenGermany",
            "Barcelona",
            "Real Madrid",
            "Chelsea",
            "Arsenal",
            "PSG"});
            this.TeamName1.Location = new System.Drawing.Point(65, 193);
            this.TeamName1.Name = "TeamName1";
            this.TeamName1.Size = new System.Drawing.Size(139, 24);
            this.TeamName1.TabIndex = 31;
            // 
            // datagrip
            // 
            this.datagrip.BackgroundColor = System.Drawing.Color.White;
            this.datagrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrip.Location = new System.Drawing.Point(578, 46);
            this.datagrip.Name = "datagrip";
            this.datagrip.RowHeadersWidth = 51;
            this.datagrip.RowTemplate.Height = 24;
            this.datagrip.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.datagrip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrip.Size = new System.Drawing.Size(710, 419);
            this.datagrip.TabIndex = 34;
            this.datagrip.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(429, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 35;
            this.label8.Text = "SecondTeam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(270, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 42;
            this.label3.Text = "Match Address";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.Search1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.VS);
            this.panel1.Controls.Add(this.Team2Id);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.IdTeam1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.PlayArea);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.PlayDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TeamName2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.datagrip);
            this.panel1.Controls.Add(this.TeamName1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-53, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1365, 522);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Search1
            // 
            this.Search1.Location = new System.Drawing.Point(272, 32);
            this.Search1.Name = "Search1";
            this.Search1.Size = new System.Drawing.Size(216, 22);
            this.Search1.TabIndex = 64;
            this.Search1.TextChanged += new System.EventHandler(this.Search1_TextChanged);
            this.Search1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Search1_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(155, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 18);
            this.label11.TabIndex = 63;
            this.label11.Text = "Team Name";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(338, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 62;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(309, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 18);
            this.label1.TabIndex = 61;
            this.label1.Text = "VS";
            // 
            // VS
            // 
            this.VS.FormattingEnabled = true;
            this.VS.Items.AddRange(new object[] {
            "VS"});
            this.VS.Location = new System.Drawing.Point(264, 193);
            this.VS.Name = "VS";
            this.VS.Size = new System.Drawing.Size(108, 24);
            this.VS.TabIndex = 60;
            // 
            // Team2Id
            // 
            this.Team2Id.Location = new System.Drawing.Point(432, 126);
            this.Team2Id.Multiline = true;
            this.Team2Id.Name = "Team2Id";
            this.Team2Id.Size = new System.Drawing.Size(100, 21);
            this.Team2Id.TabIndex = 59;
            this.Team2Id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(429, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 18);
            this.label9.TabIndex = 58;
            this.label9.Text = "Employee Id";
            // 
            // IdTeam1
            // 
            this.IdTeam1.Location = new System.Drawing.Point(68, 116);
            this.IdTeam1.Multiline = true;
            this.IdTeam1.Name = "IdTeam1";
            this.IdTeam1.Size = new System.Drawing.Size(100, 21);
            this.IdTeam1.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(65, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 18);
            this.label7.TabIndex = 56;
            this.label7.Text = "Employee Id";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(285, 463);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 55;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(1266, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "X";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // PlayArea
            // 
            this.PlayArea.FormattingEnabled = true;
            this.PlayArea.Items.AddRange(new object[] {
            "London",
            "Barcelona",
            "Madrid",
            "Liverpool",
            "Manchester"});
            this.PlayArea.Location = new System.Drawing.Point(224, 278);
            this.PlayArea.Name = "PlayArea";
            this.PlayArea.Size = new System.Drawing.Size(204, 24);
            this.PlayArea.TabIndex = 52;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(282, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 48;
            this.label5.Text = "Match Date";
            // 
            // PlayDate
            // 
            this.PlayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PlayDate.Location = new System.Drawing.Point(239, 358);
            this.PlayDate.Name = "PlayDate";
            this.PlayDate.Size = new System.Drawing.Size(174, 27);
            this.PlayDate.TabIndex = 44;
            // 
            // TeamName2
            // 
            this.TeamName2.FormattingEnabled = true;
            this.TeamName2.Items.AddRange(new object[] {
            "Manchester City",
            "Manchester United",
            "Liverpool FC",
            "Lids United",
            "Bayern MünchenGermany",
            "Barcelona",
            "Real Madrid",
            "Chelsea",
            "Arsenal",
            "PSG"});
            this.TeamName2.Location = new System.Drawing.Point(432, 193);
            this.TeamName2.Name = "TeamName2";
            this.TeamName2.Size = new System.Drawing.Size(140, 24);
            this.TeamName2.TabIndex = 40;
            // 
            // Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 563);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Match";
            this.Text = "Match";
            this.Load += new System.EventHandler(this.Match_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrip)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TeamName1;
        private System.Windows.Forms.DataGridView datagrip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker PlayDate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox PlayArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox TeamName2;
        private System.Windows.Forms.TextBox Team2Id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IdTeam1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox VS;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Search1;
        private System.Windows.Forms.Label label11;
    }
}