using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_App_WinForm_Task_4;

namespace Bank_App_WinForm_Task_4
{
    public partial class LoginForm : Form
    {
        StartupPage startupPage = new StartupPage();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            startupPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var path = @"C:\Users\Decagon\Desktop\My Decagon Experience\source\repos\Bank App WinForm Task 4\Bank App WinForm Task 4\bin\Debug\customers.Json";
            var customers = File.ReadAllText(path);


 
            var result = JsonConvert.DeserializeObject<List<Customer>>(customers);

            if(result.Any(x => x.cardNumber == AccountnumberLogin.Text && x.pin == PasswordLogin.Text))
            {
                    OptionsForm opf = new OptionsForm(AccountnumberLogin.Text);

                this.Hide();
                    opf.Show();               
            }
            else
            {
                    MessageBox.Show("Login Not Successful");
            }
        }


        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            startupPage.Show();
            startupPage.x = true;
        }

        private void AccountnumberLogin_Click(object sender, EventArgs e)
        {
            AccountnumberLogin.Text = "";
            PasswordLogin.Text = "";
        }
    }
}
