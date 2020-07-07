using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel.DataAnnotations;

namespace Week2Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversions
            Console.WriteLine("Greetings, User!");
            Console.WriteLine("We need to collect some information from you.");
            Console.WriteLine("What temperature would you like converted from Farenheit to Celcius?");
            double degreeF = Convert.ToDouble(Console.ReadLine());
            double degreeC;

            degreeC = (degreeF - 32) * 5 / 9;

            Console.WriteLine($"{degreeF}° Farenheit is {degreeC}° in Celcius.");
            Console.WriteLine();

            Console.WriteLine("Please enter a length in feet to convert to meters.");
            double lengthF = Convert.ToDouble(Console.ReadLine());
            double lengthM;

            lengthM = lengthF / 3.281;

            Console.WriteLine($"{lengthF} feet in meters is {lengthM}");
            Console.WriteLine();

            Console.WriteLine("Let's try converting Gallons, please enter a value");
            double volumeG = Convert.ToDouble(Console.ReadLine());
            double volumeL;

            volumeL = volumeG * 3.785;

            Console.WriteLine($"{volumeG} Gallons is {volumeL} Liters.");
            Console.WriteLine();

            Console.WriteLine("What weight in pounds would you like to have converted to kilograms?");
            double weightL = Convert.ToDouble(Console.ReadLine());
            double weightK;

            weightK = weightL / 2.205;

            Console.WriteLine($"{weightL} Pounds is {weightK} Kilograms.");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();

            //Formatting Money
            Console.WriteLine("Now let's play with money! Enter a number and we will list it with proper retail formatting.");
            decimal money = Convert.ToDecimal(Console.ReadLine());

            string output = string.Format("Price: {0:C}", money);
            Console.WriteLine(output);

            Console.ReadLine();


        }
    }
}
