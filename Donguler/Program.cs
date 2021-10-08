using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            String[] kurslar = new string[] { "Matematik kursu", "Türkçe Kursu", "Satranç Kursu" };

            // foreach
            Console.WriteLine("\n foreach");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            // for
            //dinamik olmayan
            Console.WriteLine("\n for, dinamik olmayan");
            for (int i = 0; i <= 2; i++)
            {
     
                Console.WriteLine(kurslar[i]); //kursların i. elemanı

            }

            // satır atla -> \n
            Console.WriteLine("\n for, dinamik olan");

            //dinamik
            for (int i = 0; i < kurslar.Length; i++)
            {

                Console.WriteLine(kurslar[i]); //kursların i. elemanı

            }



            // Array - Dizi

            /*
            
            for (int i = 1; i <= 20; i+=2)
            {
                Console.WriteLine("i: " + i);
                Console.WriteLine("Çarpma işlemi: " + i * 2);
            }
            */
        }
    }
}
