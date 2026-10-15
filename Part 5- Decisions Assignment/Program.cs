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

           // Do Loops Later

            CompassBearings();
            ParkingCost();
            Hurricane();

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
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Part 3: Hurricane Category");
            Console.WriteLine();



                                                                                                                       

        }











    }
}
