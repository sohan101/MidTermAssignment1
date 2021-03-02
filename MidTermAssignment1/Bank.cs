using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermAssignment1
{
    class Bank
    {
        public string bankName;
        private Account[] accountArry;
        private int index = 0;



        public Account[] accounts
        {
            get { return accountArry; }
            set { accountArry = value; }
        }


        public Bank(string bankName, int size)
        {
            this.bankName = bankName;
            accounts = new Account[size];
        }

        public void AddAccount(Account account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    break;
                }
            }
        }



        public void DeleteAccount(int accountNo)
        {

            if (SearchAccount(accountNo) != null)
            {
                for (int j = this.index + 1; j < accounts.Length; j++)
                {
                    accounts[j - 1] = accounts[j];
                }
                accounts[accounts.Length - 1] = null;
                Console.WriteLine("Acount Deleted");

            }
            else
            {
                Console.WriteLine("Acount not found");
            }

        }

        public Account SearchAccount(int accountNo)
        {
            Account account = null;
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i].AccountNo == accountNo && accounts[i] != null)
                {
                    this.index = i; //For deleting purpse
                    account = accounts[i];
                    break;
                }
            }
            return account;
        }


        public void Transaction(int transType, double amount, params int[] accountNo)
        {
            Account[] account = new Account[2];
            account[0] = account[1] = null;

            if (transType == 0 && accountNo.Length == 1)
            {
                account[0] = SearchAccount(accountNo[0]);

                if (account[0] == null)
                {
                    Console.WriteLine("Account Not Found");
                }
                else
                {
                    account[0].deposite(amount);
                    showDeposite(account[0], amount);
                }
            }

            else if (transType == 1 && accountNo.Length == 1)
            {

                account[0] = SearchAccount(accountNo[0]);

                if (account[0] == null)
                { Console.WriteLine("Account Not Found"); }
                else
                {
                    account[0].withdraw(amount);
                    showWithdraw(account[0], amount);
                }
            }
            else if (transType == 2 && accountNo.Length == 2)
            {
                account[0] = SearchAccount(accountNo[0]); //Sender
                account[1] = SearchAccount(accountNo[1]); //Receiver

                if (account[0] == null || account[1] == null)
                { Console.WriteLine("Account Not Found"); }

                else
                {
                    account[0].transfer(account[1], amount);
                    showTransfer(account, amount);
                }
            }
            else
                Console.WriteLine("Invalid Operation");
        }

        public void showDeposite(Account account, double amount)
        {
            Console.WriteLine("Account Number :" + account.AccountNo);
            Console.WriteLine("Account Name : " + account.AccountName);
            Console.WriteLine("Deposite Amount :" + amount);
            Console.WriteLine("Previous Balance : " + (account.Balance - amount));
            Console.WriteLine("Current Balance : " + account.Balance);
            Console.WriteLine();
        }

        public void showWithdraw(Account account, double amount)
        {
            Console.WriteLine("Account Number :" + account.AccountNo);
            Console.WriteLine("Account Name : " + account.AccountName);
            Console.WriteLine("Withdraw Amount : " + amount);
            Console.WriteLine("Previous Balance : " + (account.Balance + amount));
            Console.WriteLine("Current Balance : " + account.Balance);
            Console.WriteLine();
        }

        public void showTransfer(Account[] account, double amount)
        {
            Console.WriteLine("Sender Account Number :" + account[0].AccountNo);
            Console.WriteLine("Sender Account Name : " + account[0].AccountName);
            Console.WriteLine("Sender Previous Balance : " + (account[0].Balance + amount));
            Console.WriteLine();
            Console.WriteLine("Receiver Account Number :" + account[1].AccountNo);
            Console.WriteLine("Receiver Account Name : " + account[1].AccountName);
            Console.WriteLine("Receiver Previous Balance : " + (account[1].Balance - amount));

            Console.WriteLine();
            Console.WriteLine("Transfer Amount : " + amount);
            Console.WriteLine("Sender Current Balance : " + account[0].Balance);
            Console.WriteLine("Receiver Current Balance : " + account[1].Balance);
            Console.WriteLine();
        }






    }
}
