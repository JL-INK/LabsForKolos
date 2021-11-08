using System;
using System.Text.RegularExpressions;

namespace Lab1.Tasks
{
    class Task3
    {
        public void Task()
        {
            var Program = new Program();

            Console.Clear();
            Console.WriteLine("Введите текст");

            string text = Console.ReadLine();

            if (!Regex.IsMatch(text, @"\P{IsCyrillic}"))
            {
                Console.WriteLine("Текст введен на русском языке!");
            }
            else if(!Regex.IsMatch(text, "[a - zA - Z]"))
            {
                Console.WriteLine("Текст введен на английском языке!");
            }
            else
            {
                Console.WriteLine("Не удалось определить язык!");
            }

            Console.ReadKey();

            Program.Retry();
        }
    }
}
