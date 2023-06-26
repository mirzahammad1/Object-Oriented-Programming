namespace project
{
    partial class Transaction
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
            this.Check = new System.Windows.Forms.Button();
            this.withdraw = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.withdrawACC = new System.Windows.Forms.TextBox();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.withdrawAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.amountCHK = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Deposit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.DepositAcc = new System.Windows.Forms.TextBox();
            this.DepositAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TransferAmount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Transfer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TransferFrom = new System.Windows.Forms.TextBox();
            this.TransferTo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Check
            // 
            this.Check.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Check.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Check.Location = new System.Drawing.Point(614, 22);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(140, 34);
            this.Check.TabIndex = 39;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = false;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // withdraw
            // 
            this.withdraw.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.withdraw.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.withdraw.Location = new System.Drawing.Point(312, 119);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(140, 43);
            this.withdraw.TabIndex = 38;
            this.withdraw.Text = "withdraw";
            this.withdraw.UseVisualStyleBackColor = false;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(3, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 31);
            this.label6.TabIndex = 36;
            this.label6.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(3, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 31);
            this.label4.TabIndex = 32;
            this.label4.Text = "Withdraw";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(3, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 31);
            this.label5.TabIndex = 30;
            this.label5.Text = "Account Number";
            // 
            // withdrawACC
            // 
            this.withdrawACC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.withdrawACC.Location = new System.Drawing.Point(9, 98);
            this.withdrawACC.Name = "withdrawACC";
            this.withdrawACC.Size = new System.Drawing.Size(269, 30);
            this.withdrawACC.TabIndex = 29;
            this.withdrawACC.TextChanged += new System.EventHandler(this.withdrawACC_TextChanged);
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.BackColor = System.Drawing.SystemColors.Control;
            this.BalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.BalanceLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BalanceLabel.Location = new System.Drawing.Point(760, 21);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(198, 31);
            this.BalanceLabel.TabIndex = 28;
            this.BalanceLabel.Text = "Balance Label";
            // 
            // withdrawAmount
            // 
            this.withdrawAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.withdrawAmount.Location = new System.Drawing.Point(9, 165);
            this.withdrawAmount.Name = "withdrawAmount";
            this.withdrawAmount.Size = new System.Drawing.Size(269, 30);
            this.withdrawAmount.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 31);
            this.label2.TabIndex = 26;
            this.label2.Text = "Check Your Balance";
            // 
            // amountCHK
            // 
            this.amountCHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.amountCHK.Location = new System.Drawing.Point(327, 24);
            this.amountCHK.Name = "amountCHK";
            this.amountCHK.Size = new System.Drawing.Size(269, 30);
            this.amountCHK.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(1105, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 44);
            this.button1.TabIndex = 24;
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
            this.label1.Location = new System.Drawing.Point(487, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 42);
            this.label1.TabIndex = 23;
            this.label1.Text = "Transaction";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 585);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.Check);
            this.panel2.Controls.Add(this.BalanceLabel);
            this.panel2.Controls.Add(this.amountCHK);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(104, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 99);
            this.panel2.TabIndex = 52;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(782, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 34);
            this.button2.TabIndex = 40;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.withdraw);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.withdrawACC);
            this.panel3.Controls.Add(this.withdrawAmount);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(104, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(470, 218);
            this.panel3.TabIndex = 53;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Deposit);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.DepositAcc);
            this.panel4.Controls.Add(this.DepositAmount);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(636, 161);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(470, 218);
            this.panel4.TabIndex = 54;
            // 
            // Deposit
            // 
            this.Deposit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Deposit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Deposit.Location = new System.Drawing.Point(313, 119);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(133, 43);
            this.Deposit.TabIndex = 38;
            this.Deposit.Text = "deposit";
            this.Deposit.UseVisualStyleBackColor = false;
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(3, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 31);
            this.label8.TabIndex = 32;
            this.label8.Text = "Deposit";
            // 
            // DepositAcc
            // 
            this.DepositAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DepositAcc.Location = new System.Drawing.Point(9, 98);
            this.DepositAcc.Name = "DepositAcc";
            this.DepositAcc.Size = new System.Drawing.Size(269, 30);
            this.DepositAcc.TabIndex = 29;
            // 
            // DepositAmount
            // 
            this.DepositAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DepositAmount.Location = new System.Drawing.Point(9, 165);
            this.DepositAmount.Name = "DepositAmount";
            this.DepositAmount.Size = new System.Drawing.Size(269, 30);
            this.DepositAmount.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(3, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 31);
            this.label9.TabIndex = 30;
            this.label9.Text = "Account Number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(3, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 31);
            this.label10.TabIndex = 36;
            this.label10.Text = "Amount";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.TransferAmount);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.Transfer);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.TransferFrom);
            this.panel5.Controls.Add(this.TransferTo);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Location = new System.Drawing.Point(104, 385);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1002, 174);
            this.panel5.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(431, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 31);
            this.label3.TabIndex = 43;
            this.label3.Text = "Balance";
            // 
            // TransferAmount
            // 
            this.TransferAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TransferAmount.Location = new System.Drawing.Point(611, 127);
            this.TransferAmount.Name = "TransferAmount";
            this.TransferAmount.Size = new System.Drawing.Size(269, 30);
            this.TransferAmount.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label13.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label13.Location = new System.Drawing.Point(605, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 31);
            this.label13.TabIndex = 40;
            this.label13.Text = "Amount";
            // 
            // Transfer
            // 
            this.Transfer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Transfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Transfer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Transfer.Location = new System.Drawing.Point(886, 121);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(113, 43);
            this.Transfer.TabIndex = 38;
            this.Transfer.Text = "transfer";
            this.Transfer.UseVisualStyleBackColor = false;
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(3, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 31);
            this.label7.TabIndex = 32;
            this.label7.Text = "Transfer";
            // 
            // TransferFrom
            // 
            this.TransferFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TransferFrom.Location = new System.Drawing.Point(90, 70);
            this.TransferFrom.Name = "TransferFrom";
            this.TransferFrom.Size = new System.Drawing.Size(269, 30);
            this.TransferFrom.TabIndex = 29;
            // 
            // TransferTo
            // 
            this.TransferTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TransferTo.Location = new System.Drawing.Point(90, 124);
            this.TransferTo.Name = "TransferTo";
            this.TransferTo.Size = new System.Drawing.Size(269, 30);
            this.TransferTo.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(3, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 31);
            this.label11.TabIndex = 30;
            this.label11.Text = "From";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label12.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label12.Location = new System.Drawing.Point(3, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 31);
            this.label12.TabIndex = 36;
            this.label12.Text = "To";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::project.Properties.Resources.search;
            this.pictureBox2.Location = new System.Drawing.Point(365, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::project.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(365, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::project.Properties.Resources.back_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(15, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 584);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transaction";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox withdrawACC;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.TextBox withdrawAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amountCHK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Deposit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DepositAcc;
        private System.Windows.Forms.TextBox DepositAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TransferAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button Transfer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TransferFrom;
        private System.Windows.Forms.TextBox TransferTo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}