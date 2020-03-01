using System;
using static print_pause.View;

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

            Print("Размер массива: ");

            int sizeArr = GetInt();

            Print("Первый элемент массива: ");

            int firstEl = GetInt();

            Print("Шаг: ");

            int step = GetInt();

            Array a = new Array(sizeArr, firstEl, step);

            Print($"\n\n Сумма элеиентов {a.Sum}");
            a.Inverse = -1;

            Print($"\n\n умножиь на");
            a.Multi = GetInt();

            Print($"Max: {a.Max}");
            Print($"MaxCount: {a.MaxCount}");

            Pause();
        }
    }
}

