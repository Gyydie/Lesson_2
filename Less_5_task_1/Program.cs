using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static print_pause.View;


// Архипов Денис


//Создать программу, которая будет проверять корректность ввода логина.
// Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры,
//при этом цифра не может быть первой:
//б) ** с использованием регулярных выражений.

namespace Less_5_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int attamps = 3;

            do
            {
                Print("Введите логин: ");
                string login = Console.ReadLine();

                if (CheckLogin(login))
                {
                    break;
                }
                else
                {
                    attamps--;
                    Print($"неверно введен логин \n увас осталось {attamps} попытки");
                }
            } while (attamps > 0);

            Print("Логин введен верно!");

            Pause();
        }

        public static bool CheckLogin (string login)
        {
            char letter = login[0];
            
            if(Char.IsDigit(letter))
            {
                return false;
            }

            if(!Regex.IsMatch(login, @"^[a-zA-Z0-9]+${2,10}"))
            {
                return true;
            }

            return true;
        }
    }
}
