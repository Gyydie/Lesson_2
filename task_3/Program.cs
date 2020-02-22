using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static print_pause.View;
using static task_3.Drob;

//Архипов Денис

//Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
//Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, 
//демонстрирующую все разработанные элементы класса.


namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("числитель первой дроби: ");
            int c1 = GetInt();

            Print("знаминатель первой дроби: ");
            int z1 = GetInt();

            Print("числитель второй дроби: ");
            int c2 = GetInt();

            Print("знаминатель второй дроби: ");
            int z2 = GetInt();

            Drob function1 = new Drob(c1, z1);
            Drob function2 = new Drob(c2, z2);

            Print("Сложения: ");
            Drob result = function1.Plus(function2);
            Print(result.ToString());

            Print("Вычитания: ");
            result = function1.Minus(function2);
            Print(result.ToString());

            Print("Умножения : ");
            result = function1.Multi(function2);
            Print(result.ToString());

            Print("Деления : ");
            result = function1.Delinie(function2);
            Print(result.ToString());

            Pause();
        }

        static int GetInt()
        {
            while (true)
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

