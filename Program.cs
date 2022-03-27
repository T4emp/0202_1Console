using System;

namespace _02._02_1
{
    class Program
    {
        static void Main()
        {
            var needToContinue = true;
            while (needToContinue)
            {
                Menu();
                Console.WriteLine("Начать заново? (Ent)");
                var key = Console.ReadKey().Key;
                do
                {
                    if (key == ConsoleKey.Escape)
                    {
                        needToContinue = false;
                    }
                    else if (key != ConsoleKey.Enter)
                    {
                        Console.WriteLine("Неправильная клавиша! Начать заного? (Ent)");
                        key = Console.ReadKey().Key;
                    }
                }
                while (needToContinue && key != ConsoleKey.Enter);
                Console.Clear();
            }
        }

        static void Menu()
        {
            Console.WriteLine("Что вы хотите сделать?\n 1. Сложение\n 2. Вычитание\n 3. Умножение\n 4. Деление\n 5. Сравнение\n 6. Все сразу");
            string a1 = Console.ReadLine();
            int b1 = Convert.ToInt32(a1);
            switch (b1)
            {
                case 1:
                    Console.WriteLine("Выбрано сложение чисел.");
                    Slogenie();
                    break;
                case 2:
                    Console.WriteLine("Выбрано вычитание чисел.");
                    Vichty();
                    break;
                case 3:
                    Console.WriteLine("Выбрано умножение чисел.");
                    Ymnoz();
                    break;
                case 4:
                    Console.WriteLine("Выбрано деление чисел.");
                    Delenie();
                    break;
                case 5:
                    Console.WriteLine("Выбрано сравнение чисел.");
                    Program.Sravni();
                    break;
                case 6:
                    Console.WriteLine("Выбрано все сразу.");
                    Vse();
                    break;
            }
        }

        static void Slogenie()
        {
            //Сложение чисел
            Console.WriteLine("Введите первое число: ");
            string a2 = Console.ReadLine();
            int b2 = Convert.ToInt32(a2);
            Console.WriteLine("Введите второе число: ");
            string a3 = Console.ReadLine();
            int b3 = Convert.ToInt32(a3);
            Console.WriteLine($"Итог: {b2 + b3}");
        }

        static void Vichty()
        {
            //Вычитание чисел
            Console.WriteLine("Введите первое число: ");
            string a2 = Console.ReadLine();
            int b2 = Convert.ToInt32(a2);
            Console.WriteLine("Введите второе число: ");
            string a3 = Console.ReadLine();
            int b3 = Convert.ToInt32(a3);
            Console.WriteLine($"Итог: {b2 - b3}");
        }

        static void Ymnoz()
        {
            //Умножение чисел
            Console.WriteLine("Введите первое число: ");
            string a2 = Console.ReadLine();
            int b2 = Convert.ToInt32(a2);
            Console.WriteLine("Введите второе число: ");
            string a3 = Console.ReadLine();
            int b3 = Convert.ToInt32(a3);
            Console.WriteLine($"Итог: {b2 * b3}");
        }

        static void Delenie()
        {
            //Деление чисел
            Console.WriteLine("Введите первое число: ");
            string a2 = Console.ReadLine();
            int b2 = Convert.ToInt32(a2);
            int b3;
            do
            {
                Console.WriteLine("Введите второе число: ");
                string a3 = Console.ReadLine();
                b3 = Convert.ToInt32(a3);
            }
            while (b3 >= 0);
            Console.WriteLine($"Итог: {b2 / b3}");
        }

        static void Sravni()
        {
            // Сравнение чисел
            Console.WriteLine("Введите первое число: ");
            string a2 = Console.ReadLine();
            int b2 = Convert.ToInt32(a2);
            Console.WriteLine("Введите второе число: ");
            string a3 = Console.ReadLine();
            int b3 = Convert.ToInt32(a3);
            if (b2 > b3)
            {
                Console.WriteLine($"Число {b2} больше числа {b3}");
            }
            else if (b2 < b3)
            {
                Console.WriteLine($"Число {b2} меньше числа {b3}");
            }
            else
            {
                Console.WriteLine($"Число {b2} равно числу {b3}");
            }
        }

        static void Vse()
        {
            Console.WriteLine("Введите первое число: ");
            string a2 = Console.ReadLine();
            int b2 = Convert.ToInt32(a2);
            Console.WriteLine("Введите второе число: ");
            string a3 = Console.ReadLine();
            int b3 = Convert.ToInt32(a3);
            //Сложение чисел
            Console.WriteLine($"Итоги сложения: {b2 + b3}");
            //Вычитание чисел
            Console.WriteLine($"Итоги вычитания: {b2 - b3}");
            //Умножение чисел
            Console.WriteLine($"Итоги умножения: {b2 * b3}");
            //Деление чисел
            Console.WriteLine($"Итоги деления: {b2 / b3}");
            //Сравнение чисел
            if (b2 > b3)
            {
                Console.WriteLine($"Число {b2} больше числа {b3}");
            }
            else if (b2 < b3)
            {
                Console.WriteLine($"Число {b2} меньше числа {b3}");
            }
            else
            {
                Console.WriteLine($"Число {b2} равно числу {b3}");
            }
        }
    }
}