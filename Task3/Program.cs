using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны прямоугольника:");
            int sideA = Convert.ToInt32(Console.ReadLine());
            int sideB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону квадрата:");
            int sideC = Convert.ToInt32(Console.ReadLine());
            int number1 = 0;
            int number2 = 0;
            int res = 0;
            if (sideA > 0 && sideB > 0 && sideC > 0)
            {
                while (sideC <= sideA)
                {
                    sideA -= sideC;
                    number1++;
                }
                while (sideC <= sideB)
                {
                    sideB -= sideC;
                    number2++;
                }
                res = number1 + number2;
                Console.WriteLine("Количество квадратов, размещенных на прямоугольнике: {0}", res);
            }
            else
            {
                Console.WriteLine("Ошибка! Все размеры должны быть положительными.");
            }
            Console.ReadKey();
        }
    }
}
