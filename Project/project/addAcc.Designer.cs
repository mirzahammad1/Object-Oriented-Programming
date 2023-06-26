namespace project
{
    partial class addAcc
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
            this.ACGen = new System.Windows.Forms.ComboBox();
            this.AccountDGV = new System.Windows.Forms.DataGridView();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ACInc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ACOucc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ACaddressTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ACPhoneTh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ACNameTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // ACGen
            // 
            this.ACGen.FormattingEnabled = true;
            this.ACGen.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.ACGen.Location = new System.Drawing.Point(116, 259);
            this.ACGen.Name = "ACGen";
            this.ACGen.Size = new System.Drawing.Size(274, 24);
            this.ACGen.TabIndex = 45;
            // 
            // AccountDGV
            // 
            this.AccountDGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.AccountDGV.ColumnHeadersHeight = 29;
            this.AccountDGV.Location = new System.Drawing.Point(116, 302);
            this.AccountDGV.Name = "AccountDGV";
            this.AccountDGV.RowHeadersWidth = 51;
            this.AccountDGV.Size = new System.Drawing.Size(789, 259);
            this.AccountDGV.TabIndex = 26;
            this.AccountDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountDGV_CellContentClick);
            // 
            // Submitbtn
            // 
            this.Submitbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Submitbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Submitbtn.Location = new System.Drawing.Point(729, 253);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(176, 43);
            this.Submitbtn.TabIndex = 40;
            this.Submitbtn.Text = "Submit";
            this.Submitbtn.UseVisualStyleBackColor = false;
            this.Submitbtn.Click += new System.EventHandler(this.Submitbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(421, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 31);
            this.label6.TabIndex = 39;
            this.label6.Text = "Income";
            // 
            // ACInc
            // 
            this.ACInc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ACInc.Location = new System.Drawing.Point(427, 259);
            this.ACInc.Name = "ACInc";
            this.ACInc.Size = new System.Drawing.Size(269, 30);
            this.ACInc.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(109, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 31);
            this.label7.TabIndex = 37;
            this.label7.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(421, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 31);
            this.label4.TabIndex = 36;
            this.label4.Text = "Occupation";
            // 
            // ACOucc
            // 
            this.ACOucc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ACOucc.Location = new System.Drawing.Point(427, 192);
            this.ACOucc.Name = "ACOucc";
            this.ACOucc.Size = new System.Drawing.Size(269, 30);
            this.ACOucc.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(109, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 31);
            this.label5.TabIndex = 34;
            this.label5.Text = "Address";
            // 
            // ACaddressTb
            // 
            this.ACaddressTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ACaddressTb.Location = new System.Drawing.Point(116, 192);
            this.ACaddressTb.Name = "ACaddressTb";
            this.ACaddressTb.Size = new System.Drawing.Size(268, 30);
            this.ACaddressTb.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(421, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 31);
            this.label3.TabIndex = 32;
            this.label3.Text = "Phone";
            // 
            // ACPhoneTh
            // 
            this.ACPhoneTh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ACPhoneTh.Location = new System.Drawing.Point(427, 125);
            this.ACPhoneTh.Name = "ACPhoneTh";
            this.ACPhoneTh.Size = new System.Drawing.Size(269, 30);
            this.ACPhoneTh.TabIndex = 31;
            this.ACPhoneTh.TextChanged += new System.EventHandler(this.ACPhoneTh_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(109, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 31);
            this.label2.TabIndex = 30;
            this.label2.Text = "Name";
            // 
            // ACNameTb
            // 
            this.ACNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ACNameTb.Location = new System.Drawing.Point(115, 125);
            this.ACNameTb.Name = "ACNameTb";
            this.ACNameTb.Size = new System.Drawing.Size(269, 30);
            this.ACNameTb.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(877, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 44);
            this.button1.TabIndex = 28;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 42);
            this.label1.TabIndex = 27;
            this.label1.Text = "New Account Form";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 585);
            this.panel1.TabIndex = 25;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::project.Properties.Resources.back_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(21, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // addAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 578);
            this.Controls.Add(this.ACGen);
            this.Controls.Add(this.AccountDGV);
            this.Controls.Add(this.Submitbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ACInc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ACOucc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ACaddressTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ACPhoneTh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ACNameTb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addAcc";
            this.Text = "addAcc";
            this.Load += new System.EventHandler(this.addAcc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ACGen;
        private System.Windows.Forms.DataGridView AccountDGV;
        private System.Windows.Forms.Button Submitbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ACInc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ACOucc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ACaddressTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ACPhoneTh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ACNameTb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}