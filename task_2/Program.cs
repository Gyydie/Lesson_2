using System;
using static print_pause.View;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Архипов Денис

//а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму вывести на экран, используя tryParse;
//б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            NumbersZ();

            Pause();
        }

        public static void NumbersZ()
        {
            int b = 0;

            while (true)
            {
                Print("Введите число:");
                int n = GetInt();

                if (n != 0)
                {
                    if (n % 2 == 1)
                    {
                        b += n;
                    }
                }
                else
                {
                    break;
                }
            }
            Print(b);
        }

        static int GetInt ()
        {
            while(true)
            {
                if (!Int32.TryParse(Console.ReadLine(), out int n))
                {
                    Print("Введите ЧИСЛО:");
                }
                else
                {
                    return n;
                }
            }
        }
    }
}
