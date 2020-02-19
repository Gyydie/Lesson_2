using System;
using static print_pause.View;

namespace Less
{

    //Архипов Денис
    class Program
    {
        static void Main(string[] args)
        {
            NumberZ();
            Pause();
        }

        //1. Написать метод, возвращающий минимальное из трех чисел.
        public static void MinNumber ()
        {
            Print("Введите 1 число:");
            int a = Int32.Parse(Console.ReadLine());
            Print("Введите 2 число:");
            int b = Int32.Parse(Console.ReadLine());
            Print("Введите 3 число:");
            int c = Int32.Parse(Console.ReadLine());

            if (a<b &  a<c)
            {
                Print($"Минимальное число - {a}");
            }else if (b < a & b < c)
            {
                Print($"Минимальное число - {b}");
            }
            else if (c < a & c < b)
            {
                Print($"Минимальное число - {c}");
            }
        }

        //2. Написать метод подсчета количества цифр числа.

        public static void NumbersDigit ()
        {
            Print("Введите число:");
            int a = Int32.Parse(Console.ReadLine());
            int i = 0;
            while (a>0)
            {
                i++;
                a /= 10;
            }
            Print($"Колличество чисел: {i}");
        }

        //3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

        public static void NumberZ ()
        {
            int b = 0;

            while(true)
            {
                Print("Введите число:");
                int a = Int32.Parse(Console.ReadLine());
                
                if (a != 0 && a % 2 == 1)
                {
                    b += a;
                }
                else
                {
                    break;
                }
            }
            Print(b);
        }
    }
}
