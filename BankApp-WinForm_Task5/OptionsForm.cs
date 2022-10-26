using Newtonsoft.Json;
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

namespace Bank_App_WinForm_Task_4
{
    public partial class OptionsForm : Form
    {
        LoginForm loginForm = new LoginForm();

       static string accNo;




        public OptionsForm()
        {
             
            InitializeComponent();
        }
        public OptionsForm(string accountnumber)
        {
             accNo = accountnumber;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm(accNo);
            depositForm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WithdrawalForm withdrawalForm = new WithdrawalForm(accNo);

            withdrawalForm.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm(accNo);

            transferForm.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AccountBalanceForm accountBalanceForm = new AccountBalanceForm(accNo);

            accountBalanceForm.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            StatementOfAccountForm statementOfAccountForm = new StatementOfAccountForm(accNo);

            statementOfAccountForm.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Hide();

        }

        private void OptionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Show();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
             string path = @"C:\Users\Decagon\Desktop\My Decagon Experience\source\repos\Bank App WinForm Task 4\Bank App WinForm Task 4\bin\Debug\customers.Json";

             string customers = File.ReadAllText(path);
            List<Customer> result = JsonConvert.DeserializeObject<List<Customer>>(customers);

            var LoggedinUser = result.FirstOrDefault(x => x.cardNumber == accNo);

            welcomeUser.Text = ($"Hey {LoggedinUser.firstName}, Welcome to Your Bank");
            lblacc.Text = LoggedinUser.cardNumber;
            lblAccDashboard.Text = LoggedinUser.balance.ToString();


        }
    }
}
