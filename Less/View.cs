using System;

namespace print_pause
{
    public class View
    {
        public static void Print (object value)
        {
            Console.WriteLine(value);
        }

        public static void Pause ()
        {
            Console.ReadKey();
        }

    }
}
