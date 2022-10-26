using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_App_WinForm_Task_4;
using System.IO;


namespace Bank_App_WinForm_Task_4
{
    public partial class DepositForm : Form
    {
        public string userNumber;

        StartupPage startupPage = new StartupPage();

        

        public DepositForm()
        {
            InitializeComponent();
        }
        public DepositForm(string accountNumber)
        {
           userNumber = accountNumber;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            deposit(double.Parse(depositAmt.Text), userNumber);
            

        }

        public Customer deposit(double amount, string cardNumber) {

            string path = @"C:\Users\Decagon\Desktop\My Decagon Experience\source\repos\Bank App WinForm Task 4\Bank App WinForm Task 4\bin\Debug\customers.Json";

            string customers = File.ReadAllText(path);
            List<Customer> result = JsonConvert.DeserializeObject<List<Customer>>(customers);
            //amount = double.Parse(depositAmt.Text);

            var LoggedinUser = result.FirstOrDefault(x => x.cardNumber == cardNumber);


            LoggedinUser.balance += amount;


            var resultJson = JsonConvert.SerializeObject(result);

            File.WriteAllText(path, resultJson);

            showBalanceLabel.Text = "Your balance is" + LoggedinUser.balance.ToString();

            MessageBox.Show($"New balance = {LoggedinUser.balance}");

            return LoggedinUser;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm();
            optionsForm.Show();
            this.Hide();
        }

        private void DepositForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm();
            optionsForm.Show();
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
