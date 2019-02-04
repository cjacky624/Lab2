using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        double length;
        double width;


        static void Main(string[] args)
        {

            Console.WriteLine("Snug");
            Console.WriteLine("Enter the length of the Snug in feet");
            string snugLength = Console.ReadLine();
            Console.WriteLine("Enter the width of the Snug in feet");
            string snugWidth = Console.ReadLine();


            double snugPerimeter = Convert.ToDouble(snugLength) * 2 + Convert.ToDouble(snugWidth) * 2;

            double snugArea = Convert.ToDouble(snugLength) * Convert.ToDouble(snugWidth);


            Console.WriteLine("Perimeter: {0}", snugPerimeter);
            Console.WriteLine("Area: {0}", snugArea);

            while (true)
            { 
                Console.WriteLine("");
                Console.WriteLine("Would you like to continue measuring other rooms? Yes or No?");
                string nextMeasurement = Console.ReadLine().ToLower();

                if (nextMeasurement == "yes") 
                {
                    Console.WriteLine("Penthouse");
                    Console.WriteLine("Enter the length of the Penthouse in feet");
                    string penthouseLength = Console.ReadLine();
                    Console.WriteLine("Enter the width of the Penthouse in feet");
                    string penthouseWidth = Console.ReadLine();

                    double penthousePerimeter = Convert.ToDouble(penthouseLength) * 2 + Convert.ToDouble(penthouseWidth) * 2;

                    double penthouseArea = Convert.ToDouble(penthouseLength) * Convert.ToDouble(penthouseWidth);

                    Console.WriteLine("Perimeter: {0}", penthousePerimeter);

                    Console.WriteLine("Area: {0}", penthouseArea);

                    Console.WriteLine("Congratulations, you have calculated the perimeter and area of the Snug and Penthouse!");

                    break;

                }
                
                else if (nextMeasurement == "no")
                {

                    break;
                }
                else
                {
                    Console.WriteLine("Input not recognized, please try again.");
                    continue;
                        
                }

            }
        }

    }
}
