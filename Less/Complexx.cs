using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less
{
    class Complexx
    {
        private double im;
        private double re;

        public Complexx()
        {
            im = 0;
            re = 0;
        }

        public Complexx(double im, double re)
        {
            this.im = im;
            this.re = re;
        }

        public Complexx Minus(Complexx x2)
        {
            Complexx x3 = new Complexx();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }

        public Complexx Multi(Complexx x2)
        {
            Complexx x3 = new Complexx();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;
            return x3;
        }

        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
}

