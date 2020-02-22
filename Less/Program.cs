using System;
using static print_pause.View;

namespace Less
{

    //Архипов Денис


//а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры;
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса;
    struct Complex
    {
        public double im;
        public double re;

        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }

        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Complex result = complex1.Plus(complex2);
            Print(result.ToString());

            result = complex1.Multi(complex2);
            Print(result.ToString());

            result = complex1.Minus(complex2);
            Print(result.ToString());

            Print("задание 2 с классом");

            Complexx com1 = new Complexx(1, 1);

            Complexx com2 = new Complexx(2, 2);

            Complexx result_1 = com1.Minus(com2);
            Print(result_1.ToString());

            result_1 = com1.Multi(com2);
            Print(result_1.ToString());

            Pause();
        }
    }
}
