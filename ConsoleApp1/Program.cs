using System;

namespace ConsoleApp1
{
    class Program
    {
        static double Avrage(double a, double b)
        {
            return ((a + b) / (double)2);
        }

        static double Divide_by_avrage(double num,double avrage)
        {
            return (num / (double)avrage);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("please enter a real number above 0");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the range of answuer (between 0-1) ");
            double digit =double.Parse( Console.ReadLine());

            double min = 1;
            double max = num;

            int count = 0;
            while ((max-min)>= digit )
            {
                count++;
                double tempMin = Avrage(min, max);
                double tempMax = Divide_by_avrage(num, tempMin);

                if (tempMin>tempMax)
                {
                    max = tempMin;
                    min = tempMax;
                }
                else
                {
                    max = tempMax;
                    min = tempMin;
                }
            }

            if (Math.Floor(max) * Math.Floor(max) == num)
            {
                Console.WriteLine("the root is {0}",Math.Floor(max));
            }
            else
            {
                Console.WriteLine("the root is between {0} and {1}", min, max);
                Console.WriteLine(count);
            }
            
            
        }
    }
}
