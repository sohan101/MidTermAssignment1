using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermAssignment1
{
    class Bank
    {
        private string name;
        private Account[] accounts;//1-* Relation
        public Bank(string name, int size)
        {
            this.name = name;
            accounts = new Account[size];
        }
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public Account[] Accounts
        {
            set { this.accounts = value; }
            get { return this.accounts; }
        }

        public void PrintAllAccounts()
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                accounts[i].PrintAccount();
            }
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
        public void SearchAccount(int accountNo)
        {
            int flag = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                else if (accounts[i].AccountNo == accountNo)
                {
                    accounts[i].PrintAccount();
                    flag = 0;
                    break;
                }
                else
                {
                    flag = 1;

                }
            }
            if (flag == 1)
                Console.WriteLine("Account Not Found");
        }

        public void DeleteAccount(int accountNo)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                else if (accounts[i].AccountNo == accountNo)
                {
                    accounts[i] = null;
                    for (int j = i; j < (accounts.Length - 1); j++)
                    {
                        accounts[j] = accounts[j + 1];
                    }
                    Console.WriteLine("Account Deleted");
                    break;
                }

            }

            //public void Transaction(int transType, double amount, int accountsNo)
            //{

            //          if (transaction == 1)
            //        { 
            //        }
            //            if (transType == 0 && accounts.Length == 1)
            //    {
            //        account[0] = PrintAccount(accounts[0]);

            //        if (account[0] == null)
            //        {
            //            Console.WriteLine("Account Not Found");
            //        }
            //        else
            //        {
            //            accounts[0].deposite(amount);
            //            showDeposite(accounts[0], amount);
            //        }
            //    }

            //    else if (transType == 1 && accounts.Length == 1)
            //    {

            //        account[0] = SearchAccount(accounts[0]);

            //        if (account[0] == null)
            //        { Console.WriteLine("Account Not Found"); }
            //        else
            //        {
            //            account[0].withdraw(amount);
            //            showWithdraw(account[0], amount);
            //        }
            //    }
            //    else if (transType == 2 && accountNo.Length == 2)
            //    {
            //        account[0] = SearchAccount(accounts[0]); 
            //        account[1] = SearchAccount(accounts[1]); 

            //        if (account[0] == null || account[1] == null)
            //        { Console.WriteLine("Account Not Found"); }

            //        else
            //        {
            //            account[0].transfer(account[1], amount);
            //            showTransfer(account, amount);
            //        }
            //    }
            //    else
            //        Console.WriteLine("Invalid Operation");
            //}

            void showDeposite(Account account, double amount)
            {
                Console.WriteLine("Account Number :" + account.AccountNo);
                Console.WriteLine("Account Name : " + account.AccountName);
                Console.WriteLine("Deposite Amount :" + amount);
                Console.WriteLine("Previous Balance : " + (account.Balance - amount));
                Console.WriteLine("Current Balance : " + account.Balance);
                Console.WriteLine();
            }

            void showWithdraw(Account account, double amount)
            {
                Console.WriteLine("Account Number :" + account.AccountNo);
                Console.WriteLine("Account Name : " + account.AccountName);
                Console.WriteLine("Withdraw Amount : " + amount);
                Console.WriteLine("Previous Balance : " + (account.Balance + amount));
                Console.WriteLine("Current Balance : " + account.Balance);
                Console.WriteLine();
            }

            void showTransfer(Account[] account, double amount)
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
}

