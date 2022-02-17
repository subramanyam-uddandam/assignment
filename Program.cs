using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_On
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client C1 = new Client();
         
            Console.WriteLine(" select one option login or register");
            string abc = Console.ReadLine();
            if (abc == "login")
            {
                C1.Login();
            }
            else if (abc == "register")
            {
                C1.Registration();
            }
            else
            {
                Console.WriteLine("please select \"Login\" or \"register\" ");
            }

            Console.Read();


        }
    }
}
