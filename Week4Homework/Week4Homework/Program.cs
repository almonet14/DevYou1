using System;

namespace Week4Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number");
            int letterN = Convert.ToInt16(Console.ReadLine());
            int countUp = 1;
            int countDown = letterN;

            //Count Up to n
            do
            {
                Console.WriteLine($"{countUp}");
                countUp++;
            }
            while (countUp <= letterN);

            Console.ReadLine();
            Console.Clear();

            //Count Down from n
            do
            {
                Console.WriteLine($"{countDown}");
                countDown--;
            }
            while (countDown >= 1);

            Console.ReadLine();
            Console.Clear();

            //Alphabet
            char alpha = 'a';
            do
            {
                Console.WriteLine($"{alpha}");
                alpha++;
            }
            while (alpha != 'z');
            Console.WriteLine("z");
            Console.ReadLine();
            Console.Clear();

            //List of Evens
            int evens = 0;
            
            while (evens <= 100)
            {
                Console.WriteLine($"{evens}");
                evens += 2;
            }

            Console.ReadLine();
            Console.Clear();

            //List of Odds
            int odds = 1;

            while (odds <= 100)
            {
                Console.WriteLine($"{odds}");
                odds += 2;
            }

            Console.ReadLine();
            Console.Clear();

            //Sum of 1-n
            int factA = 0;
            int sum = 0;

            //Gauss Formula
            int gauss = letterN / 2 * (1 + letterN);
            Console.WriteLine($"Σ of n+1 is {gauss}");
            Console.WriteLine("But, let's check that work...");
            Console.ReadLine();

            //Table works now .... Magically
            while (factA <= letterN)
            {
                Console.WriteLine($"{factA} ... {sum}");                                        
                factA += 1;
                sum = factA + sum;
            }


            Console.ReadLine();

            //Multiplication Table
            int product;
            int count = 1;

            while (count <= letterN)
            {
                product = letterN * count;
                Console.WriteLine($"{letterN} x {count} = {product}");
                count++;
            }

            Console.ReadLine();
        }
    }
}
