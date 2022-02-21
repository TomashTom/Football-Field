
namespace Football_Field
{
    partial class displayusers
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
            this.datagrip = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrip)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrip
            // 
            this.datagrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrip.Location = new System.Drawing.Point(57, 53);
            this.datagrip.Name = "datagrip";
            this.datagrip.RowHeadersWidth = 51;
            this.datagrip.RowTemplate.Height = 24;
            this.datagrip.Size = new System.Drawing.Size(953, 320);
            this.datagrip.TabIndex = 0;
            this.datagrip.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrip_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // displayusers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datagrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "displayusers";
            this.Text = "displayusers";
            this.Load += new System.EventHandler(this.displayusers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrip;
        private System.Windows.Forms.Button button1;
    }
}