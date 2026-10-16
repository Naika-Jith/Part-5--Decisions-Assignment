 using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Part_5__Decisions_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Decisions Assignment";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the Decisions Assignment!");
            Console.WriteLine();
            Console.WriteLine("Please press ENTER to continue");
            Console.ReadLine();
            Console.Clear();

            //*********************

            int choice = 0;

            while (choice != 4)
            {
                Console.Clear();
                Console.WriteLine("Main Menu");
                Console.WriteLine();
                Console.WriteLine("1. Compass Bearings");
                Console.WriteLine("2. Parking Cost");
                Console.WriteLine("3. Hurricane Category");
                Console.WriteLine("4. Exit");
                Console.WriteLine();

                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            CompassBearings();
                            break;

                        case 2:
                            ParkingCost();
                            break;

                        case 3:
                            Hurricane();
                            break;

                        case 4:
                            Console.WriteLine("Exiting program...");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }

                if (choice != 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Press ENTER to return to the menu.");
                    Console.ReadLine();
                }
            }

        }


        static void CompassBearings()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Part 1: Compass Bearings");
            Console.WriteLine();

            Console.Write(" Please Input an angle in degrees (0-360):");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double angle))
            {
                if (angle >= 0 && angle <= 360)
                {
                    if (angle == 0 || angle == 360)
                    {
                        Console.WriteLine("The bearing is North.");
                    }
                    else if (angle > 0 && angle < 90)
                    {
                        Console.WriteLine("The bearing is North-East.");
                    }
                    else if (angle == 90)
                    {
                        Console.WriteLine("The bearing is East.");
                    }
                    else if (angle > 90 && angle < 180)
                    {
                        Console.WriteLine("The bearing is South-East.");
                    }
                    else if (angle == 180)
                    {
                        Console.WriteLine("The bearing is South.");
                    }
                    else if (angle > 180 && angle < 270)
                    {
                        Console.WriteLine("The bearing is South-West.");
                    }
                    else if (angle == 270)
                    {
                        Console.WriteLine("The bearing is West.");
                    }
                    else if (angle > 270 && angle < 360)
                    {
                        Console.WriteLine("The bearing is North-West.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 360.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        static void ParkingCost()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Part 2: Parking Cost");
            Console.WriteLine();

            
           Console.Write("Please enter the number of minutes parked: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int minutes))
            {
                if (minutes < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a non-negative number.");
                    return;
                }
                // Calculate hours, (Math.Ceiling) rounds the number up to the nearest whole number
                int hours = (int)Math.Ceiling(minutes / 60.0);
                // Calculate cost
                double cost;
                if (hours <= 1)
                {
                    cost = 4.00; // Minimum fee for the first hour
                }
                else
                {
                    cost = 4.00 + (hours - 1) * 2.00; // $2 for each additional hour
                    if (cost > 20.00)
                    {
                        cost = 20.00; // Maximum charge for the day
                    }
                }
                Console.WriteLine($"You are being charged for {hours} hour(s).");
                Console.WriteLine($"The total cost is: {cost:C}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        }

        static void Hurricane()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Part 3: Hurricane Category");
            Console.WriteLine();

            Console.Write("Enter the hurricane wind speed in mph: ");

            int speed;
            while (!int.TryParse(Console.ReadLine(), out speed))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Console.WriteLine();
                Console.Write("Enter the hurricane wind speed in mph: ");
            }
            switch (speed)
            {
                case int n when (n >= 74 && n <= 95):
                    Console.WriteLine("Category 1");
                    Console.WriteLine("Wind speed: " + speed + " mph");
                    Console.WriteLine("64-82 knots");
                    Console.WriteLine("119-153 km/hr");
                    break;

                case int n when (n >= 96 && n <= 110):
                    Console.WriteLine("Category 2");
                    Console.WriteLine("Wind speed: " + speed + " mph");
                    Console.WriteLine("83-95 knots");
                    Console.WriteLine("154-177 km/hr");
                    break;

                case int n when (n >= 111 && n <= 130):
                    Console.WriteLine("Category 3");
                    Console.WriteLine("Wind speed: " + speed + " mph");
                    Console.WriteLine("96-113 knots");
                    Console.WriteLine("178-209 km/hr");
                    break;

                case int n when (n >= 131 && n <= 155):
                    Console.WriteLine("Category 4");
                    Console.WriteLine("Wind speed: " + speed + " mph");
                    Console.WriteLine("114-135 knots");
                    Console.WriteLine("210-249 km/hr");
                    break;

                case int n when (n > 155):
                    Console.WriteLine("Category 5");
                    Console.WriteLine("Wind speed: " + speed + " mph");
                    Console.WriteLine("Greater than 135 knots");
                    Console.WriteLine("Greater than 249 km/hr");
                    break;

                default:
                    Console.WriteLine("Not a hurricane (below Category 1).");
                    break;



            }

        }
    }
}
