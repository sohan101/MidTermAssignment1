using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermAssignment1
{
    class Program
    {
  
        static void Main(string[] args)
        {

            Bank ourBank = new Bank("Developer's bank", 5);
            ourBank.AddAccount(new Account(1001, "Shakib", 2000, new Address(4, 10, "Dhaka", "Bangladesh")));
            ourBank.AddAccount(account: new Account(3003, "Mushfiq", 5000, new Address(4, 10, "Sylhet", "Bangladesh")));
            ourBank.AddAccount(new Account(1002, "Tamim", 3000, new Address(7, 20, "Chittagong", "Bangladesh")));
            ourBank.PrintAllAccounts();
            //ourBank.SearchAccount(300);

        }

        
    }
}
