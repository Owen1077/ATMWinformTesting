using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bank_App_WinForm_Task_4;

namespace WinFormTest
{
    [TestClass]
    public class UnitTest1
    {
          
        //FOR THE CHECK IF DEPOSIT FUNCTION WORKS AND THE CHECK IF WITHDRAWAL FUNCTION WORKS,
        //I HAD TO EQUATE THE VALUES SO THAT THEY BALANCE BETWEEN 165000 AND 164000,
        //SO IF YOU WANT TO CHANGE THE VALUES, ADJUST THEM TO BALANCE EACHOTHER OUT!

        [TestMethod]
        public void checkIfDepositFunctionWorks()
        {            
            //string firstName = "Owen";
            //string lastName = "Archer";
            //string accountType = "Savings";
            //string password = "2222";
            //string email = "fwcs";
            //double balance = 10000;
            //Customer customer = new Customer(firstName, lastName, cardNumber, password, balance, email, accountType);

            //Arrange

            string cardNumber = "0402204235";

            double expected = 165000;
            double amount = 1000;
            DepositForm depositForm = new DepositForm();

            //Act
           var customer = depositForm.deposit(amount, cardNumber);

            //Assert
            Assert.AreEqual(expected, customer.balance);
        }

        [TestMethod]
        public void checkIfWithdrawalFunctionWorks()
        {
            //string firstName = "Owen";
            //string lastName = "Archer";
            //string accountType = "Savings";
            //string password = "2222";
            //string email = "fwcs";
            //double balance = 10000;
            //Customer customer = new Customer(firstName, lastName, cardNumber, password, balance, email, accountType);


            //Arrange
            string cardNumber = "0402204235";

            double expected = 164000;
            double amount = 1000;
            WithdrawalForm withdrawForm = new WithdrawalForm(cardNumber);

            //Act
           var customer = withdrawForm.withdraw(amount, cardNumber);

            //Assert
            Assert.AreEqual(expected, customer.balance);
        }

        [TestMethod]
        public void passwordCheck()
        {
            //Arrange
            string expected = "AAaa11@@";
            RegistrationForm registrationForm = new RegistrationForm();
           
            //Act
            var x = registrationForm.checkPassword(expected);

            //Assert
            Assert.IsTrue(x);

        }

        [TestMethod]
        public void emailCheck()
        {
            //Arrange
            string expected = "abc123@gmail.com";
            RegistrationForm registrationForm = new RegistrationForm();
            //Act
            var x = registrationForm.checkEmail(expected);
            //Assert
            Assert.IsTrue(x);
        }

        [TestMethod]
        public void firstNameCheck()
        {
            //Arrange
            string expected = "Owen";
            RegistrationForm registrationForm = new RegistrationForm();

            //Act
            var x = registrationForm.checkFirstName(expected);
            //Assert
            Assert.IsTrue(x);

        }
        [TestMethod]
        public void lastNameCheck()
        {
            //Arrange
            string expected = "Archer";
            RegistrationForm registrationForm = new RegistrationForm();
           //Act
            var x = registrationForm.checkLastName(expected);
            //Asserrt
            Assert.IsTrue(x);

        }



        [TestMethod]
        public void checkIftransferFunctionWorks()
        {
            //Arrange
            string firstName = "Owen";
            string lastName = "Archer";
            string accountType = "Savings";
            string password = "2222";
            string email = "fwcs";
            double balance = 10000;


            string cardNumber = "0426618345";
            string recipientNumber = "0552830606";

            Customer customer = new Customer(firstName, lastName, cardNumber, password, balance, email, accountType);
            Customer customer1 = new Customer(firstName, lastName, recipientNumber, password, balance, email, accountType);

           


            double expected = 350000;
            double amount = 50000;
            TransferForm transferForm = new TransferForm(cardNumber);

            //Act
            customer = transferForm.transfer(amount, cardNumber, customer1.cardNumber);

            //Assert
            Assert.AreEqual(expected, customer.balance);
        }
    }
}
