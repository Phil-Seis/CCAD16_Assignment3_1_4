//CCAD Assignment 3-1-4
//Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.

using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;

namespace CCAD16_Assignment3_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your coordinates (x,y) and I will let you know what quadrant you are in");
            Quadrant();            
        }

        static void Quadrant()
        {
            Console.WriteLine("Input the value for X coordinate: ");
            int xCoord = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the value for Y coordinate: ");
            int yCoord = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your point lies at coordinates: ({xCoord}, {yCoord})");

            if (xCoord == 0 && yCoord != 0)
            {
                Console.WriteLine("Your point falls on the X-Axis");
            }

            else if (xCoord != 0 && yCoord == 0)
            {
                Console.WriteLine("Your point falls on the Y-Axis");
            }            
                
            switch (true)
            {
                case bool when xCoord > 0 && yCoord > 0:
                    Console.WriteLine("Your point is located in Quandrant 1");
                    break;
                case bool when xCoord < 0 && yCoord > 0:
                    Console.WriteLine("Your point is located in Quadrant 2");
                    break;
                case bool when xCoord < 0 && yCoord < 0:
                    Console.WriteLine("Your point is located in Quadrant 3");
                    break;
                case bool when xCoord > 0 && yCoord < 0:
                    Console.WriteLine("Your point is located in Quadrant 4");
                    break;
            }
        }
    }
}
