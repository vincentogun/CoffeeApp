using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            version();
            //PrintColorMessage(ConsoleColor.Red, "Please use an Actual Number");



            int coffeeCost = 0;
            string userDecision = string.Empty;

            int userChoice = -1;
            do
            {

                Console.WriteLine("Pick selcet your Coffee : 1 - Small($5), 2 - Medium($13), 3 - Large($15)");
                //Console.WriteLine("                           ");
                userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        coffeeCost += 5;
                        break;
                    case 2:
                        coffeeCost += 13;
                        break;
                    case 3:
                        coffeeCost += 15;
                        break;
                    default:
                        Console.WriteLine("Your choice {0} is invalid. Please try again", userChoice);
                        break;
                }

                while (userChoice != 1 && userChoice != 2 && userChoice != 3) ;



                Console.WriteLine("Bill = ${0}.00", coffeeCost);
                //Console.WriteLine("=====================================================");
                Console.WriteLine("                                                                   ");

                do
                {
                    Console.WriteLine("Do you wish to purchase another item: Yes/No");
                    userDecision = Convert.ToString(Console.ReadLine().ToUpper());

                    if (userDecision != "YES" && userDecision != "NO")
                    {
                        Console.WriteLine("Your choice {0} is invalid, Please try again...", userDecision);
                    }

                } while (userDecision != "YES" && userDecision != "NO");

            }

            while (userDecision.ToUpper() != "NO");



            //Console.WriteLine(name);

            Console.ReadKey();
        }       

        static void version()
        {
            //Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("[APP VERSION 2.5.8]...");
            Console.ResetColor();
            Console.WriteLine("====================================================");
            Console.WriteLine("                                          ");

        }


        
    }
}
