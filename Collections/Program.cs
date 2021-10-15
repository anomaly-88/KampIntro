using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //isimler = new string[5];
            // isimler[4] = "İlker";
            // Console.WriteLine(isimler[4]);
            // Console.WriteLine(isimler[0]);

            Console.WriteLine("\n"); // boşluk bırak

            // 1. Yöntem
            List<string> isimler2 = new List<string>();

            isimler2.Add("Bu bir string List. ve bu isimler2 string list in 0. indexli 1. elemanı");
            isimler2.Add("Yukarıdaki Array örneğimi uyguluyorum. ve bu isimler2 string list in 1. indexli 2. elemanı");
            isimler2.Add("Engin");
            isimler2.Add("Murat");
            isimler2.Add("Kerem");
            isimler2.Add("Halil");
            isimler2.Add("İlker");

            // 2. yöntem, dikkat et normal parantezler kaltı.
            List<string> isimler3 = new List<string> { "Engin", "Murat", "Kerem", "Halil", "İlker" };

            // Generic List lerimin ikisini de yazdırıyorum
            for (int i = 0; i < isimler2.Count; i++)
            {
                Console.WriteLine(isimler2[i]);
            }

            Console.WriteLine("\n"); // boşluk bırak

            for (int i = 0; i < isimler3.Count; i++)
            {
                Console.WriteLine(isimler3[i]);
            }
        }
    }
}
