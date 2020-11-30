using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace VacationBudgetPlanner
{
    class Program
    {
        const int h = 24;
        const int m = 60;

        static void Main(string[] args)
        {

            string pinNumber = "1234";
            bool isValidPin = false;

            Console.WriteLine("Hi, please enter your pin number. You will have 3 chances to enter your pin.");

            for (int i = 0; i < 3; i++)
            {
                Console.Write("What is your pin: ");
                string userPin = Console.ReadLine();

                if (userPin == pinNumber)
                {
                    isValidPin = true;
                    break;
                }

            }


            if (isValidPin)
            {
                bool tryagain = true;
                while (tryagain == true)
                {
                    // Vacation Budget Planner
                    Console.WriteLine("Welcome to Vacation Budget Planner");

                    Console.WriteLine("Please enter your name");

                    string name = Console.ReadLine();


                    Console.WriteLine("Welcome " + name + " where would you like to travel today, Mexico or Jamaica?");

                    Console.WriteLine("Please choose 1 for Mexico or 2 for Jamaica.");

                    int travel = Convert.ToInt32(Console.ReadLine());





                    switch (travel)
                    {
                        // Mexico Side
                        case 1:

                            Console.WriteLine("Great, Mexico sounds like amazing trip!");
                            Console.WriteLine("********************");
                            Console.WriteLine("How many days do you plan on spending in Mexico?");

                            int days = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("How much money in USD do you plan to spend on your trip?");

                            int money1 = Convert.ToInt32(Console.ReadLine());

                            string m1 = money1.ToString("C");

                            int h1 = (days * h);
                            int min1 = (h1 * m);
                            int sum1 = (money1 / days);

                            int dp = (int)(1 * 20.14);
                            int p1 = (money1 * dp) / days;

                            string s1 = sum1.ToString("C");
                            string s2 = p1.ToString("C");

                            Console.WriteLine("Great, you plan to spend " + m1 + " and can spend " + s1 + " per day in USD.");

                            Console.WriteLine("You plan to spend " + m1 + " and can spend " + s2 + " per day in Pesos.");

                            Console.WriteLine("Enjoy your trip!");

                            break;

                        // Jamaica Side
                        case 2:

                            Console.WriteLine("Great, Jamaica sounds like amazing trip!");
                            Console.WriteLine("********************");
                            Console.WriteLine("How many days do you plan on spending in Jamaica?");

                            int days2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("How much money in USD do you plan to spend on your trip?");

                            int money2 = Convert.ToInt32(Console.ReadLine());

                            string m2 = money2.ToString("C");

                            int h2 = (days2 * h);
                            int min2 = (h2 * m);
                            int sum2 = (money2 / days2);

                            int dj = (int)(1 * 148.14);
                            int j1 = (money2 * dj) / days2;

                            string s3 = sum2.ToString("C");
                            string s4 = j1.ToString("C");

                            Console.WriteLine("Great, you plan to spend " + m2 + " and can spend " + s3 + " per day in USD.");

                            Console.WriteLine("You plan to spend " + m2 + " and can spend " + s4 + " per day in Jamaican Dollars.");

                            Console.WriteLine("Enjoy your trip!");

                            break;


                        default:

                            Console.WriteLine("Sorry you much choose 1 for Mexico or 2 for Jamacia.");
                            Console.WriteLine("Would you like to try again? Press y for yes and n for No.");

                            break;




                    }
                    string user = Console.ReadLine().ToLower();

                    if (user == "n")
                    {
                        tryagain = false;

                        Console.WriteLine("Please press enter to exit.");
                        Console.ReadLine();
                    }

                }
            }
            else
            {
                Console.WriteLine("You have exceeded the allowed number of attempts.");
            }

            
                
                    
                        
            
                    Console.ReadLine();

        }
    }
}
