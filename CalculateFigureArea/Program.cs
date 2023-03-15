using System;
using System.Text;

namespace CalculateFigureArea
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Выберите фигуру для расчёта площади:");
                Console.WriteLine("1 - площадь круга\n2 - площадь треугольника\nx - выход");

                switch (Console.ReadLine()) 
                {
                    case "1":
                        Console.WriteLine("Расчёт площади круга");
                        break;
                    case "2":
                        Console.WriteLine("Расчёт площади треугольника");
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Неверное имя фигуры");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
