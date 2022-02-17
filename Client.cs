using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_On
{
    internal class Client
    {
        public void Login()
        {
            Console.Write("enter the num to login :");
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine("num: " + number);
            Console.Write("welcome to watsapp...");
            Console.WriteLine();
            Console.WriteLine("please enter \"1\"for add clients,\"2\"for edit,and\"3\" for delete");
            string options = Console.ReadLine();
            Console.WriteLine(options);
    

            if (options == "1")
            {
                String[] clientName = new String[20];
                long[] clientPhoneNumber = new long[10];
                String[] clientEmail = new String[20];
                String[] clientAdress = new String[20];
                int n;
                Console.WriteLine("Enter How many clients data do you want to enter:");
                n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("\nEnter the Name of Client:");
                    clientName[i] = Console.ReadLine();
                    Console.WriteLine("Enter Phone number:");
                    clientPhoneNumber[i] = Convert.ToInt64(Console.ReadLine());
                    Console.Write("enter the num :");
                }
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("\nClient " + (j + 1) + " details: ");
                    Console.WriteLine("Name of the Client: " + clientName[j]);
                    Console.WriteLine("Phone number: " + clientPhoneNumber[j]);
                }
            }
            else if (options == "2")
            {
                Console.Write("enter the num :");
                long phnumber = long.Parse(Console.ReadLine());
                Console.WriteLine("num: " + phnumber);
                Console.Write("enter the name :");
                string Cname = Console.ReadLine();
                Console.WriteLine("your contact is.." + Cname);
                Console.Write("contact edited sucessfully");
            }
            else if (options == "3")
            {
                Console.Write("enter the name :");
                string Cname = Console.ReadLine();
                Console.WriteLine("your contact is.." + Cname);
                Console.Write("name deleted sucessfully");

            }
            else
            {
                Console.WriteLine("please enter the num between 1 to 3");
            }
        }

        public void Registration()
        {
            Console.Write("enter the num :");
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine("num: " + number);
            Console.Write("enter the name :");
            string name = Console.ReadLine();
            Console.WriteLine("your name is.." + name);
            Console.Write("welcome to watsapp...");
            Console.WriteLine("please enter 1 to add Clients \n 2 for edit and \n 3 for delete");
            string options = Console.ReadLine();
            Console.WriteLine(options);

            if (options == "1")
            {
                String[] clientName = new String[20];
                long[] clientPhoneNumber = new long[10];
                String[] clientEmail = new String[20];
                String[] clientAdress = new String[20];
                int n;
                Console.WriteLine("Enter How many clients data do you want to enter:");
                n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("\nEnter the Name of Client:");
                    clientName[i] = Console.ReadLine();
                    Console.WriteLine("Enter Phone number:");
                    clientPhoneNumber[i] = Convert.ToInt64(Console.ReadLine());
                    Console.Write("enter the num :");
                }
            }
            else if (options == "2")
            {
                Console.Write("enter the num :");
                long phnumber = long.Parse(Console.ReadLine());
                Console.WriteLine("num: " + phnumber);
                Console.Write("enter the name :");
                string Cname = Console.ReadLine();
                Console.WriteLine("your contact is.." + Cname);
                Console.Write("contact edited sucessfully");
            }
            else if (options == "3")
            {
                Console.Write("enter the name :");
                string Cname = Console.ReadLine();
                Console.WriteLine("your contact is.." + Cname);
                Console.Write("name deleted sucessfully");
            }
            else
            {
                Console.WriteLine("please enter the num between 1 to 3");
            }
        }
    }
}
