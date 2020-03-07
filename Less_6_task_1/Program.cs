using System;

//Архипов Денис

//Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double).
//Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).


namespace Less_6_task_1
{
    class Program
    {
        public delegate double Fun(double a, double x);

        static void Main(string[] args)
        {
            Console.WriteLine("Таблица функции a*x^2:");
            Table(new Fun(MyFunc), -1.5, -2, 2);

            Console.WriteLine("Таблица функции a*sin(x):");
            Table(new Fun(MyFunc), 3, -2, 2);

            Console.ReadKey();
        }

        public static void Table(Fun F, double a, double x, double b)
        {
            Console.WriteLine("----- A ------- X -------- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(a, x));
                x += 1;
            }
            Console.WriteLine("-----------------------------------");
        }

        public static double MyFunc(double a, double x)
        {
            return a * x * x;
        }
    }
}
