namespace Bank_App_WinForm_Task_4
{
    partial class LoginForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.AccountnumberLogin = new System.Windows.Forms.TextBox();
            this.PasswordLogin = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(294, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "SIGN IN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AccountnumberLogin
            // 
            this.AccountnumberLogin.ForeColor = System.Drawing.Color.Gray;
            this.AccountnumberLogin.Location = new System.Drawing.Point(33, 23);
            this.AccountnumberLogin.Name = "AccountnumberLogin";
            this.AccountnumberLogin.Size = new System.Drawing.Size(181, 20);
            this.AccountnumberLogin.TabIndex = 1;
            this.AccountnumberLogin.Text = "Account Number";
            this.AccountnumberLogin.Click += new System.EventHandler(this.AccountnumberLogin_Click);
            // 
            // PasswordLogin
            // 
            this.PasswordLogin.ForeColor = System.Drawing.Color.Gray;
            this.PasswordLogin.Location = new System.Drawing.Point(33, 82);
            this.PasswordLogin.Name = "PasswordLogin";
            this.PasswordLogin.Size = new System.Drawing.Size(181, 20);
            this.PasswordLogin.TabIndex = 2;
            this.PasswordLogin.Text = "Password";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(294, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 160);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PasswordLogin);
            this.Controls.Add(this.AccountnumberLogin);
            this.Controls.Add(this.button1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AccountnumberLogin;
        private System.Windows.Forms.TextBox PasswordLogin;
        private System.Windows.Forms.Button button2;
    }
}