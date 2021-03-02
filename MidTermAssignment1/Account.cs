using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermAssignment1
{
    class Account
    {
		private int accountNo;
		private string accountName;
		private double balance;
		private Address address;

		public static int count = 1101;

		public Account()
		{
			accountNo = count;
			count++;
		}

		public Account(string accountName, double balance, Address address) : this()
		{

			this.accountName = accountName;
			this.balance = balance;
			this.address = address;
		}

		public int AccountNo 
		{ 
			get { return this.accountNo; } 
		}
		public string AccountName 
		{ 
			set { this.accountName = value; } 
			get { return this.accountName; } 
		}
		public double Balance 
		{ 
			set { this.balance = value; } 
			get { return this.balance; } 
		}
		public Address _Address 
		{ 
			set { this.address = value; } 
			get { return this.address; } 
		}

		virtual public void ShowAccountInformation() { }

		virtual public bool withdraw(double amount)
		{
			if (this.balance - amount < 0)
			{
				Console.WriteLine("Insufficient Amount");
				return false;
			}
			else
			{
				this.balance -= amount;
				return true;
			}
		}

		public void deposite(double amount)
		{

			Balance += amount;

		}


		public void transfer(Account recever, double amount)
		{
			if (this.withdraw(amount) == true)
			{
				recever.deposite(amount);

			}
			else
			{
				Console.WriteLine("Transfer Failed");

			}

		}
		public void PrintAccount()
		{
			Console.WriteLine("Account No:{0}\nAccount Name:{1}\nBalance:{2}", this.accountNo, this.accountName, this.balance);
			this.address.PrintAddress();
		}
	}
}
