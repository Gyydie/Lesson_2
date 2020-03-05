using System;

namespace print_pause
{
    public class View
    {
        public static void Print (object value, bool isNewLine = true)
        {
            if (isNewLine)
            {
                Console.WriteLine(value);
            }
            else
            {
                Console.Write(value);
            }
        }

        public static void Pause ()
        {
            Console.ReadKey();
        }
    }
}
