using System;
using System.Linq;

namespace Lab1.Tasks
{
    class Task2
    {
        public void Task()
        {
            var Program = new Program();

        Start:
            {
                Console.Clear();
                Console.WriteLine("Введите текст (максимальное количество символов равняется 200)");
                string text = Console.ReadLine().ToLower();
                int quantity = 0;

                if (text.Length > 200)
                {
                    Console.WriteLine("Введен слишком большой текст. Повторите ввод!");
                    Console.ReadKey();
                    goto Start;
                }
            Quantuty:
                {
                    Console.WriteLine("Сколько букв найти?");
                    try
                    {
                        quantity = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Введите корректное число!");
                        Console.ReadKey();
                        goto Quantuty;
                    }
                }

                char[] arrayLetter = new char[quantity];

                for (int i = 0; i < quantity; i++)
                {
                Letter:
                    {
                        Console.WriteLine("Введите букву которая вас интересует");
                        try
                        {
                            arrayLetter[i] = Convert.ToChar(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Введена не верная буква!");
                            Console.ReadKey();
                            goto Letter;
                        }
                    }
                }

                for (int j = 0; j < quantity; j++)
                {
                    Console.WriteLine($"Буква {arrayLetter[j]} встречается в тексте {text.Count(ch => ch == arrayLetter[j])} раз(а).");
                }
                Console.ReadKey();

                Program.Retry();
            }
        }
    }
}
