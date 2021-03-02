using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermAssignment1
{
    class Program
    {
        public enum Transaction { Deposite, Withdraw, Transfer }
        static void Main(string[] args)
        {
            Bank bank = new Bank("Jokers Bank Ltd", 100);
            Console.WriteLine(">>>>>>>>>> Jokers Bank Ltd <<<<<<<<<<");
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine(" > open \n > account \n > quit");
                Console.WriteLine("............................................");
                Console.WriteLine();
                Console.Write(">>");
                string Case = System.Console.ReadLine();

                
            }

        }
    }
}
