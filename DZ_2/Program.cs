using System;

namespace DZ_2
{

    class Program
    {
        static double segment1(double x)
        {
            double y;
            y = x + 7;
            return Math.Round(y,2);
        }

        static double segment2(double x)
        {

            double y;
            y = 4.0;
            return Math.Round(y, 2);
        }

        static double segment3(double x)
        {
            double y;
            y = x * x;
            return Math.Round(y, 2);
        }

        static double segment4(double x)
        {
            double y;
            y = 2 * (-x + 4);
            return Math.Round(y, 2);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите промежуток на котором нужно найти значения функции:");
            Console.WriteLine("x1=");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("x2=");
            double x2 = double.Parse(Console.ReadLine());
            if(x1>x2)
            {
                Console.WriteLine("Неккоректно введён промежуток");
            }

            for (double x = x1; x <= x2; x += 0.2)
            {
                x = Math.Round(x, 2);
                if ((x < -7) || (x > 4))
                {
                    Console.WriteLine($"Функция не определена для x={x}");
                }

                else if ((x >= -7) && (x <= -3))
                {
                    Console.WriteLine($"Для 1-й функции x={x},  y={segment1(x)}");
                }

                else if ((x >= -3) && (x <= -2))
                {
                    Console.WriteLine($"Для 2-й функции x={x},  y={segment2(x)}");
                }

                else if ((x >= -2) && (x <= 2))
                {
                    Console.WriteLine($"Для 3-й функции x={x},  y={segment3(x)}");
                }

                else if ((x >= 2) && (x <= 4))
                {
                    Console.WriteLine($"Для 4-й функции x={x},  y={segment4(x)}");
                }
            }
        }
    }
}
