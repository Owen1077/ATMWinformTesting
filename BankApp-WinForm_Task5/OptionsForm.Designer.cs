﻿namespace Bank_App_WinForm_Task_4
{
    partial class OptionsForm
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
            this.welcomeUser = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.lblacc = new System.Windows.Forms.Label();
            this.lblAccDashboard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomeUser
            // 
            this.welcomeUser.AutoSize = true;
            this.welcomeUser.Location = new System.Drawing.Point(51, 25);
            this.welcomeUser.Name = "welcomeUser";
            this.welcomeUser.Size = new System.Drawing.Size(265, 13);
            this.welcomeUser.TabIndex = 0;
            this.welcomeUser.Text = "Welciome, firstName, what would you like to do today?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(54, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 147);
            this.button1.TabIndex = 1;
            this.button1.Text = "DEPOSIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Indigo;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(325, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 147);
            this.button2.TabIndex = 2;
            this.button2.Text = "WITHDRAW";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Indigo;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(588, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(167, 147);
            this.button3.TabIndex = 3;
            this.button3.Text = "TRANSFER";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Indigo;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(54, 268);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 147);
            this.button4.TabIndex = 4;
            this.button4.Text = "BALANCE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Indigo;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(325, 268);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(167, 147);
            this.button5.TabIndex = 5;
            this.button5.Text = "STATEMENT OF ACCOUNT";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(588, 268);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(167, 147);
            this.button6.TabIndex = 6;
            this.button6.Text = "LOG OUT";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblacc
            // 
            this.lblacc.AutoSize = true;
            this.lblacc.Location = new System.Drawing.Point(668, 25);
            this.lblacc.Name = "lblacc";
            this.lblacc.Size = new System.Drawing.Size(87, 13);
            this.lblacc.TabIndex = 7;
            this.lblacc.Text = "Account Number";
            // 
            // lblAccDashboard
            // 
            this.lblAccDashboard.AutoSize = true;
            this.lblAccDashboard.Location = new System.Drawing.Point(683, 38);
            this.lblAccDashboard.Name = "lblAccDashboard";
            this.lblAccDashboard.Size = new System.Drawing.Size(35, 13);
            this.lblAccDashboard.TabIndex = 8;
            this.lblAccDashboard.Text = "label1";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAccDashboard);
            this.Controls.Add(this.lblacc);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.welcomeUser);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OptionsForm_FormClosing);
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label lblacc;
        private System.Windows.Forms.Label lblAccDashboard;
    }
}