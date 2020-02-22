using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static print_pause.View;

namespace task_3
{
    class Drob
    {
        private int cheslit;
        private int znamenat;

        public Drob ()
        {
            cheslit  = 1;
            znamenat = 1;
        }

        public Drob (int c, int z)
        {
            this.cheslit   =  c;
            this.znamenat  =  z;
        }
        
        public Drob Plus (Drob x)
        {
            Drob y     =  new Drob();
            y.cheslit  =  x.cheslit + this.cheslit;
            y.znamenat =  (this.znamenat * (y.cheslit / this.cheslit)) - (x.znamenat * (y.cheslit / x.cheslit));
            return y;
        }

        public Drob Minus(Drob x)
        {
            Drob y     = new Drob();
            y.cheslit  = x.cheslit - this.cheslit;
            y.znamenat = (this.znamenat * (y.cheslit / this.cheslit)) - (x.znamenat * (y.cheslit / x.cheslit));
            return y;
        }

        public Drob Multi(Drob x)
        {
            Drob y     = new Drob();
            y.cheslit  = x.cheslit  * this.cheslit;
            y.znamenat = x.znamenat * znamenat;
            return y;
        }

        public Drob Delinie(Drob x)
        {
            Drob y     = new Drob();
            y.cheslit  = x.znamenat * cheslit;
            y.znamenat = x.cheslit  * znamenat;
            return y;
        }

        public string ToString()
        {
            return "(" + cheslit + "/" + znamenat + ")";
        }
    }
}
