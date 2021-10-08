using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primative tip olan int bir değer tiptir. Primative tipe sahip değişkenler değerleri tutarlar. (int, str, bool, double, float..)
            int sayi1 = 30;
            int sayi2 = 60;
            sayi1 = sayi2;
            sayi2 = 99;
            Console.WriteLine(sayi1);


            // Array bir referans tiptir. Referans tipe sahip değişkenler adresleri tutarlar. (Class, Abstract Class, Array, Interface..)
            int[] sayilar1 = new int[] { 1,3,5,7,9 };
            int[] sayilar2 = new int[] { 2, 4, 6, 8 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            foreach (int sayi in sayilar1)
            {
                Console.Write(sayi+" ");
            }
        }
    }
}
