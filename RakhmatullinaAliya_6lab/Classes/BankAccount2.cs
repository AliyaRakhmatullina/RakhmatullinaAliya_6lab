using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RakhmatullinaAliya_6lab
{
    internal class BankAccount2
    {
        public class BankAccount
        {

            public enum AccountType
            {
                Savings,
                Checking,
                Credit
            }


            private static int nextAccountNumber = 1000;


            private string accountNumber;
            private decimal balance;
            private AccountType accountType;


            public BankAccount()
            {

                accountNumber = GenerateAccountNumber();
            }


            private string GenerateAccountNumber()
            {
                return (nextAccountNumber++).ToString();
            }


            public void SetBalance(decimal balance)
            {
                this.balance = balance;
            }

            public void SetAccountType(AccountType accountType)
            {
                this.accountType = accountType;
            }


            public string GetAccountNumber()
            {
                return accountNumber;
            }

            public decimal GetBalance()
            {
                return balance;
            }

            public AccountType GetAccountType()
            {
                return accountType;
            }

           
            public void DisplayInfo()
            {
                Console.WriteLine($"Account Number: {accountNumber}");
                Console.WriteLine($"Balance: {balance} USD");
                Console.WriteLine($"Account Type: {accountType}");
            }
        }
    }
}
