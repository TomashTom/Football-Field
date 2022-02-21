
namespace Football_Field
{
    partial class Ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.control = new System.Windows.Forms.TabControl();
            this.Receipt = new System.Windows.Forms.TabPage();
            this.abc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Order = new System.Windows.Forms.TabPage();
            this.Details = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TeamName2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Qty = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TeamName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OrdDate = new System.Windows.Forms.DateTimePicker();
            this.CusName = new System.Windows.Forms.TextBox();
            this.CusPH = new System.Windows.Forms.TextBox();
            this.SeatPla = new System.Windows.Forms.TextBox();
            this.CustId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.print = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.control.SuspendLayout();
            this.Receipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.Order.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 637);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(723, 351);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(631, 199);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(87, 94);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 33);
            this.button5.TabIndex = 71;
            this.button5.Text = "Print";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label14.Location = new System.Drawing.Point(26, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(177, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Order Total Details:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.control);
            this.groupBox3.Location = new System.Drawing.Point(723, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(631, 333);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // control
            // 
            this.control.Controls.Add(this.Receipt);
            this.control.Controls.Add(this.Order);
            this.control.Location = new System.Drawing.Point(6, 0);
            this.control.Name = "control";
            this.control.SelectedIndex = 0;
            this.control.Size = new System.Drawing.Size(619, 327);
            this.control.TabIndex = 0;
            this.control.SelectedIndexChanged += new System.EventHandler(this.control_SelectedIndexChanged);
            // 
            // Receipt
            // 
            this.Receipt.Controls.Add(this.abc);
            this.Receipt.Controls.Add(this.label5);
            this.Receipt.Controls.Add(this.grid);
            this.Receipt.Location = new System.Drawing.Point(4, 25);
            this.Receipt.Name = "Receipt";
            this.Receipt.Padding = new System.Windows.Forms.Padding(3);
            this.Receipt.Size = new System.Drawing.Size(611, 298);
            this.Receipt.TabIndex = 1;
            this.Receipt.Text = "Details";
            this.Receipt.UseVisualStyleBackColor = true;
            // 
            // abc
            // 
            this.abc.ForeColor = System.Drawing.Color.Black;
            this.abc.Location = new System.Drawing.Point(237, 261);
            this.abc.Name = "abc";
            this.abc.Size = new System.Drawing.Size(216, 22);
            this.abc.TabIndex = 68;
            this.abc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.abc_KeyPress_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 18);
            this.label5.TabIndex = 67;
            this.label5.Text = "Customer Detail Search";
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.GridColor = System.Drawing.Color.DarkGray;
            this.grid.Location = new System.Drawing.Point(6, 6);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(599, 242);
            this.grid.TabIndex = 0;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // Order
            // 
            this.Order.Controls.Add(this.Details);
            this.Order.Location = new System.Drawing.Point(4, 25);
            this.Order.Name = "Order";
            this.Order.Padding = new System.Windows.Forms.Padding(3);
            this.Order.Size = new System.Drawing.Size(611, 298);
            this.Order.TabIndex = 2;
            this.Order.Text = "Order";
            this.Order.UseVisualStyleBackColor = true;
            // 
            // Details
            // 
            this.Details.Location = new System.Drawing.Point(6, 6);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(513, 264);
            this.Details.TabIndex = 33;
            this.Details.Text = "";
            this.Details.TextChanged += new System.EventHandler(this.Details_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.TeamName2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.Qty);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.TeamName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(11, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 307);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
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
            this.TeamName2.Location = new System.Drawing.Point(466, 85);
            this.TeamName2.Name = "TeamName2";
            this.TeamName2.Size = new System.Drawing.Size(139, 24);
            this.TeamName2.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label6.Location = new System.Drawing.Point(354, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 71;
            this.label6.Text = "Team Name";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(216, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 28);
            this.button4.TabIndex = 67;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(254, 187);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 30);
            this.button7.TabIndex = 70;
            this.button7.Text = "Reset";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(78, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 28);
            this.button3.TabIndex = 68;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(42, 187);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 27);
            this.button6.TabIndex = 69;
            this.button6.Text = "Receipt";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Qty
            // 
            this.Qty.Location = new System.Drawing.Point(137, 133);
            this.Qty.Multiline = true;
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(139, 21);
            this.Qty.TabIndex = 63;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 66;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TeamName
            // 
            this.TeamName.FormattingEnabled = true;
            this.TeamName.Items.AddRange(new object[] {
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
            this.TeamName.Location = new System.Drawing.Point(137, 84);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(139, 24);
            this.TeamName.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label4.Location = new System.Drawing.Point(25, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Qty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label7.Location = new System.Drawing.Point(292, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Football Match ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.Location = new System.Drawing.Point(25, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Team Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.OrdDate);
            this.groupBox1.Controls.Add(this.CusName);
            this.groupBox1.Controls.Add(this.CusPH);
            this.groupBox1.Controls.Add(this.SeatPla);
            this.groupBox1.Controls.Add(this.CustId);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(280, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 24);
            this.label3.TabIndex = 71;
            this.label3.Text = "Customer Information";
            // 
            // OrdDate
            // 
            this.OrdDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.OrdDate.Location = new System.Drawing.Point(494, 118);
            this.OrdDate.Name = "OrdDate";
            this.OrdDate.Size = new System.Drawing.Size(174, 27);
            this.OrdDate.TabIndex = 59;
            // 
            // CusName
            // 
            this.CusName.Location = new System.Drawing.Point(183, 127);
            this.CusName.Multiline = true;
            this.CusName.Name = "CusName";
            this.CusName.Size = new System.Drawing.Size(108, 21);
            this.CusName.TabIndex = 62;
            // 
            // CusPH
            // 
            this.CusPH.Location = new System.Drawing.Point(183, 176);
            this.CusPH.Multiline = true;
            this.CusPH.Name = "CusPH";
            this.CusPH.Size = new System.Drawing.Size(100, 21);
            this.CusPH.TabIndex = 61;
            // 
            // SeatPla
            // 
            this.SeatPla.Location = new System.Drawing.Point(494, 171);
            this.SeatPla.Multiline = true;
            this.SeatPla.Name = "SeatPla";
            this.SeatPla.Size = new System.Drawing.Size(170, 21);
            this.SeatPla.TabIndex = 60;
            // 
            // CustId
            // 
            this.CustId.Location = new System.Drawing.Point(183, 73);
            this.CustId.Multiline = true;
            this.CustId.Name = "CustId";
            this.CustId.Size = new System.Drawing.Size(108, 21);
            this.CustId.TabIndex = 59;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label13.Location = new System.Drawing.Point(392, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 18);
            this.label13.TabIndex = 6;
            this.label13.Text = "Order Date:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label10.Location = new System.Drawing.Point(392, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Seat Place";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label9.Location = new System.Drawing.Point(17, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Consumers Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(17, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Costumers Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(17, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CostumersID:";
            // 
            // print
            // 
            this.print.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.print.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.print.ClientSize = new System.Drawing.Size(400, 300);
            this.print.Document = this.printDocument1;
            this.print.Enabled = true;
            this.print.Icon = ((System.Drawing.Icon)(resources.GetObject("print.Icon")));
            this.print.Name = "printPreviewDialog1";
            this.print.Visible = false;
            this.print.Load += new System.EventHandler(this.print_Load);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 624);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.control.ResumeLayout(false);
            this.Receipt.ResumeLayout(false);
            this.Receipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.Order.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TeamName;
        private System.Windows.Forms.TextBox CusName;
        private System.Windows.Forms.TextBox CusPH;
        private System.Windows.Forms.TextBox SeatPla;
        private System.Windows.Forms.TextBox CustId;
        private System.Windows.Forms.TextBox Qty;
        private System.Windows.Forms.DateTimePicker OrdDate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TabControl control;
        private System.Windows.Forms.TabPage Receipt;
        private System.Windows.Forms.TabPage Order;
        private System.Windows.Forms.RichTextBox Details;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.PrintPreviewDialog print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox abc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TeamName2;
        private System.Windows.Forms.Label label6;
    }
}