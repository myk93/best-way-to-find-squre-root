using System;

namespace ConsoleApp1
{
    class Program
    {
        static long pow_by(long a,int b=1)
        {
            for (int i = 0; i < b; i++)
            {
                a *= 10;
            }
            return a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a real number above 2");
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine("enter the range of answuer (between 0-1)");
            double digit =double.Parse( Console.ReadLine());

            double min = 1;
            double max = num;
            long base_div = 1000;
            int count = 0;
            while (num>pow_by(base_div,2*count+3))
            {
                count++;
                if (num < pow_by(base_div, 2*count + 3))
                {
                   
                    min = pow_by(base_div, count);
                    max = (num / (double)min);
                    if (min > max)
                    {
                        double temp = max;
                        max = min;
                        min = temp;
                    }
                }
            }
           
           
            while ((max-min)>= digit )
            {
                count++;
                max = ((min + max) / (double)2);
                min = (num / (double)max);
                if (min > max)
                {
                    double temp = max;
                    max = min;
                    min = temp;
                }
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
