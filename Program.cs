using System;
using System.ComponentModel;

namespace Deneme2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 3;
            int b = 4;
            int sonuc=0;
            sonuc = ArttırveTopla(ref a, ref b);

        }

        public int ArttırveTopla(ref int x, ref int y)
        {
            x++;
            y += y;

            return (x+y);
        }

    }
}