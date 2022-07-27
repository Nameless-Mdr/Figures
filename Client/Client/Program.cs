using Figures;
using System;

namespace Client
{
    class Program
    {
        static double Square(Figure figure)
        {
            return figure == null ? 0 : figure.Square();
        }

        static void Main(string[] args)
        {
            Figure figure = null;

            int k = -1;

            while (k != 0)
            {
                Console.Clear();
                Console.WriteLine(@"Выберите фигуру:
1-Окружность
2-Треугольник
0-Выход");
                if(!int.TryParse(Console.ReadLine(), out k))
                {
                    Console.WriteLine("Некорректно веденные данные");
                    k = -1;
                }

                switch (k)
                {
                    case 1:
                        Console.Write("Введите радиус: ");

                        if(double.TryParse(Console.ReadLine(), out double r))
                        {
                            try
                            {
                                figure = new Circle(r);
                                Console.WriteLine(Square(figure));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Exception: {ex.Message}");
                            }
                        }
                        else
                            Console.WriteLine("Некорректно веденные данные");

                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Write("Введите первую сторону: ");
                        if (!double.TryParse(Console.ReadLine(), out double a))
                        {
                            Console.WriteLine("Некорректно веденные данные");
                            Console.ReadKey();
                            break;
                        }

                        Console.Write("Введите вторую сторону: ");
                        if (!double.TryParse(Console.ReadLine(), out double b))
                        {
                            Console.WriteLine("Некорректно веденные данные");
                            Console.ReadKey();
                            break;
                        }

                        Console.Write("Введите третью сторону: ");
                        if (!double.TryParse(Console.ReadLine(), out double c))
                        {
                            Console.WriteLine("Некорректно веденные данные");
                            Console.ReadKey();
                            break;
                        }

                        try
                        {
                            figure = new Triangle(a, b, c);
                            Console.WriteLine(Square(figure));

                            if(figure is Triangle)
                            {
                                if(((Triangle)figure).IsRightTriangle())
                                    Console.WriteLine("Треугольник прямоугольный");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Exception: {ex.Message}");
                        }

                        Console.ReadKey();
                        break;
                }
            }

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
