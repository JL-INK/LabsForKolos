using System;

namespace Lab1
{
    class Program
    {
        static void Main()
        {
            var Task1 = new Tasks.Task1();
            var Task2 = new Tasks.Task2();
            var Task3 = new Tasks.Task3();

            Heading();
        Task:
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        {
                            Console.Clear();
                            Task1.Task();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Task2.Task();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Task3.Task();
                            break;
                        }
                }
            }
            catch
            {
                Console.WriteLine("Задания под таким номером не существует. Повторите ввод!");
                goto Task;
            }
        }

        static void Heading()
        {
            Console.Clear();
            Console.WriteLine(new string('-', 119));
            Console.WriteLine("|" + new string(' ', 52) + "Здравствуйте!" + new string(' ', 52) + "|");
            Console.WriteLine("|" + new string(' ', 50) + "Введите № задания" + new string(' ', 50) + "|");
            Console.WriteLine("|" + new string(' ', 102) + "by Frantsev V." + new string(' ', 1) + "|");
            Console.WriteLine(new string('-', 119));
        }

        public void Retry()
        {
            Console.Clear();
            Console.WriteLine("Нажмите любую кнопку для повторения или Esc для выхода");

            var button = Console.ReadKey();

            if (button.Key == ConsoleKey.Escape)
            {
                return;
            }
            else
            {
                Main();
            }
        }

    }
}


