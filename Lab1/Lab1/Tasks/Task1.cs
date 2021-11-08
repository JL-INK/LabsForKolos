using System;

namespace Lab1.Tasks
{
    class Task1
    {
        public void Task()
        {
            var Program = new Program();

            double[,] dotsArray = new double[4, 2];
            string[] dot = { "a", "b", "c", "d" };

            for (int i = 0; i < dotsArray.GetLength(0); i++)
            {
                Console.WriteLine($"Введите координаты точки {dot[i]}.");

                for (int j = 0; j < dotsArray.GetLength(1); j++)
                {
                Number:
                    {
                        try
                        {
                            dotsArray[i, j] = Convert.ToDouble(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Вы ввели не число, повторите попытку!");
                            goto Number;
                        }
                    };
                }

                Console.Clear();
            }

            //Math.Sqrt((x2 - x1)*2 + (y2 - y1)*2); ---Формула нахождения расстояния между точками

            double ab = Math.Sqrt((dotsArray[1, 0] - dotsArray[0, 0]) * 2 + (dotsArray[1, 1] - dotsArray[0, 1]) * 2);
            double ac = Math.Sqrt((dotsArray[2, 0] - dotsArray[0, 0]) * 2 + (dotsArray[2, 1] - dotsArray[0, 1]) * 2);
            double ad = Math.Sqrt((dotsArray[3, 0] - dotsArray[0, 0]) * 2 + (dotsArray[3, 1] - dotsArray[0, 1]) * 2);
            double bc = Math.Sqrt((dotsArray[2, 0] - dotsArray[1, 0]) * 2 + (dotsArray[2, 1] - dotsArray[1, 1]) * 2);
            double bd = Math.Sqrt((dotsArray[3, 0] - dotsArray[1, 0]) * 2 + (dotsArray[3, 1] - dotsArray[1, 1]) * 2);
            double cd = Math.Sqrt((dotsArray[3, 0] - dotsArray[2, 0]) * 2 + (dotsArray[3, 1] - dotsArray[2, 1]) * 2);

            double a = max(ab, ac);
            double b = max(ad, bc);
            double c = max(bd, cd);
            double d = max(a, b);
            double e = max(c, d);
            double f = max(d, e);

            if (f == ab)
            {
                Console.WriteLine("Точки a и b находятся на максимальном удалении друг от друга.");
            }
            if (f == ac)
            {
                Console.WriteLine("Точки a и c находятся на максимальном удалении друг от друга.");
            }
            if (f == ad)
            {
                Console.WriteLine("Точки a и d находятся на максимальном удалении друг от друга.");
            }
            if (f == bc)
            {
                Console.WriteLine("Точки b и c находятся на максимальном удалении друг от друга.");
            }
            if (f == bd)
            {
                Console.WriteLine("Точки b и d находятся на максимальном удалении друг от друга.");
            }
            if (f == cd)
            {
                Console.WriteLine("Точки c и d находятся на максимальном удалении друг от друга.");
            }

            Console.ReadKey();

            Program.Retry();
        }

        protected double max(double x, double y)
        {
            if (x > y)
            {
                return x;
            }
            else
            {
                return y;
            }
        }
    }
}
