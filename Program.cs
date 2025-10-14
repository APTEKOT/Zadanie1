using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Климов_Фигуры
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Расчёт площади и длины окружности + расчёт площади и периметра прямоугольника\n");
            double s_circle, s_rect, c_circle, p_rect, r, a, b, choice, s_ball, v_ball;
            string s;
            Console.WriteLine("Какую фигуру использовать?\n[0] - окружность\n[1] - прямоугольник\n[2] - шар\n");

            s = Console.ReadLine();
            choice = Convert.ToDouble(s);
            if (choice == 1)
            {
                Console.WriteLine("Что вычислять?\n[0] - площадь\n[1] - периметр\n");
                s = Console.ReadLine();
                choice = Convert.ToDouble(s);
                Console.WriteLine("Значения А и В");
                s = Console.ReadLine();
                a = Convert.ToDouble(s);
                s = Console.ReadLine();
                b = Convert.ToDouble(s);
                if (choice == 1)
                {
                    Console.WriteLine("Что вычислять?\n[0] - площадь\n[1] - периметр\n");
                    s = Console.ReadLine();
                    choice = Convert.ToDouble(s);
                    Console.WriteLine("Значения А и В");
                    s = Console.ReadLine();
                    a = Convert.ToDouble(s);
                    s = Console.ReadLine();
                    b = Convert.ToDouble(s);
                    if (choice == 1)
                    {
                        p_rect = (a + b) * 2;
                        Console.WriteLine("\nПериметр прямоугольника: {0}", p_rect);
                    }
                    else
                    {
                        s_rect = a * b;
                        Console.WriteLine("\nПлощадь прямоугольника: {0}", s_rect);
                    }
                }
                else if (choice == 0)
                {
                    Console.WriteLine("Что вычислять?\n[0] - площадь\n[1] - длину окружности\n");
                    s = Console.ReadLine();
                    choice = Convert.ToDouble(s);
                    Console.WriteLine("Радиус");
                    s = Console.ReadLine();
                    r = Convert.ToDouble(s);
                    if (choice == 1)
                    {
                        c_circle = 2 * r * Math.PI;
                        Console.WriteLine("\nДлина окружности: {0}", c_circle);
                    }
                    else
                    {
                        s_circle = r * Math.PI * Math.PI;
                        Console.WriteLine("\nПлощадь круга: {0}", s_circle);
                    }
                }
            }
        }
    }
}
