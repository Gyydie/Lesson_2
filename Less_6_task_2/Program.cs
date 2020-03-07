﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;



//Архипов Денис

//Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
//а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить минимум.Использовать массив(или список) делегатов, в котором хранятся различные функции.
//б) * Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она возвращает минимум через параметр(с использованием модификатора out). 


namespace MinFunc
{
    public delegate double Fun(double x);

    class Program
    {
        public static void SaveFunc(string fileName, double start, double end, double step, Fun F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);

            while (start <= end)
            {
                bw.Write(F(start));
                start += step;
            }
            bw.Close();
            fs.Close();
        }

        public static double[] Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);

            double[] array = new double[fs.Length / sizeof(double)];
            min = double.MaxValue;
            double d;

            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                array[i] = d;
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return array;
        }

        static double secondDegree(double x)
        {
            return x * x;
        }

        static double thirdDegree(double x)
        {
            return x * x * x;
        }

        static double mySqrt(double x)
        {
            return Math.Sqrt(x);
        }

        static int GetInt(int max)
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x) || x > max)
                    Console.Write("Неверный ввод", max);
                else return x;
        }

        static void GetInterval(out double start, out double end)
        {
            string[] interval = Console.ReadLine().Split(' ');
            start = double.Parse(interval[0], CultureInfo.InvariantCulture);
            end = double.Parse(interval[1], CultureInfo.InvariantCulture);
        }

        static void PrintResults(double start, double end, double step, double[] values)
        {
            Console.WriteLine("------- X ------- Y -----");
            int index = 0;
            while (start <= end)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} ", start, values[index]);
                start += step;
                index++;
            }
            Console.WriteLine("--------------------------");
        }

        static void Main(string[] args)
        {
            List<Fun> functions = new List<Fun> { new Fun(secondDegree), new Fun(thirdDegree), new Fun(mySqrt)};

            Console.WriteLine("Выберите функцию");

            Console.WriteLine("1) y^2");
            Console.WriteLine("2) y^3");
            Console.WriteLine("3) y^1/2");

            int userChoose = GetInt(functions.Count);

            Console.WriteLine("Задайте отрезок через пробел:");

            double start = 0;
            double end = 0;
            GetInterval(out start, out end);

            Console.WriteLine("Задайте шаг дискредитирования:");

            double step = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            SaveFunc("data.bin", start, end, step, functions[userChoose - 1]);

            double min = double.MaxValue;

            Console.WriteLine("Получены следующие значения функции: ");

            PrintResults(start, end, step, Load("data.bin", out min));

            Console.WriteLine("Минимальное значение функции равняется: {0:0.00}", min);

            Console.ReadKey();
        }
    }
}