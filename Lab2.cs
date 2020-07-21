using System;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string contin;
            contin = "y";

            while (contin == "y")
            {

                Console.WriteLine("Welcome to Grand Circus Room Detail Generator!");

                Console.WriteLine("Enter Length:");
                decimal length;
                length = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Enter Width:");
                decimal width = decimal.Parse(Console.ReadLine());

                decimal area = length * width;
                decimal perimeter = 2 * (length * width);

                Console.WriteLine("Area:" + area + "ft");
                Console.WriteLine("Perimeter:" + perimeter + "ft²");

                Console.WriteLine("Continue? (y/n)");
                contin = Console.ReadLine();
            }
        }


    }
}
