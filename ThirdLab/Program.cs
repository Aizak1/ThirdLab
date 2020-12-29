using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double? y;
            Console.WriteLine("Enter Function's argument");
            x = double.Parse(Console.ReadLine());
            y = СalculateFunctionValue(x);
            OutPutFunctionValue(y);
        }

        private static void OutPutFunctionValue(double? y)
        {
            if (y == null)
            {
                Console.WriteLine("Function is undefined");
            }
            else
            {
                Console.WriteLine($"Funtion's value = {y}");
            }
        }

        private static double? СalculateFunctionValue(double x)
        {
            double? y;
            if (x >= -10 && x < -6)
            {
                const int radius = 2;
                y = Math.Sqrt(Math.Pow(radius, 2) - Math.Pow((x + 8), 2)) - 2;
            }
            else if (x >= -6 && x <= 2)
            {
                y = (x / 2) + 1;
            }
            else if (x > 2 && x < 6)
            {
                y = 0;
            }
            else if (x >= 6 && x <= 8)
            {
                y = Math.Pow((x - 6), 2);
            }
            else
            {
                y = null;
            }

            return y;
        }
    }
}
