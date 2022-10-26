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
    public partial class AccountBalanceForm : Form
    {
        public string AccNo;

       
        public AccountBalanceForm(string accountNumber)
        {
            AccNo = accountNumber;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Decagon\Desktop\My Decagon Experience\source\repos\Bank App WinForm Task 4\Bank App WinForm Task 4\bin\Debug\customers.Json";

            string customers = File.ReadAllText(path);
            List<Customer> result = JsonConvert.DeserializeObject<List<Customer>>(customers);

            var LoggedinUser = result.FirstOrDefault(x => x.cardNumber == AccNo);

            MessageBox.Show($"Your balance is {LoggedinUser.balance}");

            OptionsForm optionsForm = new OptionsForm();
            optionsForm.Show();
            this.Hide();

        }

        private void AccountBalanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm();
            optionsForm.Show();
        }

        private void AccountBalanceForm_Load(object sender, EventArgs e)
        {
         
        }
    }
}
