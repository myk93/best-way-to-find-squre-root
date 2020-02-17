using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a real number above 0");
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine("enter the range of answuer (between 0-1)");
            double digit =double.Parse( Console.ReadLine());

            double min = 1;
            double max = num;

            int count = 0;
            while ((max-min)>= digit )
            {
                count++;
                max = ((min + max) / (double)2);
                min = (num / (double)max);
            }

            if (Math.Floor(max) * Math.Floor(max) == num)
            {
                Console.WriteLine("the root is {0}",Math.Floor(max));
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine("the root is between {0} and {1}", min, max);
                Console.WriteLine(count);
            }
        }
    }
}
