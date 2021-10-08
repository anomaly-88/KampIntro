using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "Matematik";
            kurs1.kursEgitmen = "Engin Günaydın";
            kurs1.kursIlerlemeOrani = 70;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Java";
            kurs2.kursEgitmen = "Gamze Özçelik";
            kurs2.kursIlerlemeOrani = 87;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "C#";
            kurs3.kursEgitmen = "Mustafa Kemal";
            kurs3.kursIlerlemeOrani = 98;


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                /*Console.WriteLine(kurs.kursAdi);
                Console.WriteLine(kurs.kursEgitmen);
                Console.WriteLine(kurs.kursIlerlemeOrani);

                Console.WriteLine("-----------------");
                */

                Console.WriteLine("Kurs Adı : " + kurs.kursAdi + "\n" +
                                  "Kurs Eğitmeni : " + kurs.kursEgitmen + "\n" +
                                  "Kurs İlerleme Oranı : " + kurs.kursIlerlemeOrani +
                                  "\n");
            }

            
        
        }
        
        class Kurs
        {
            public string kursAdi { get; set; }
            public string kursEgitmen { get; set; }
            public int kursIlerlemeOrani { get; set; }
        }
    }
}
