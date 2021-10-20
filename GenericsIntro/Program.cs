using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");

            //Aşağıya yazacaklarım Önümüzdeki haftanın konusu, sadece bunu test etmek için yapıyorum, siz yazmayın.
            //Buradaki Lenght, bizim Class'ımızdaki Lenght.
            Console.WriteLine(isimler.Lenght); //Evet şuanda 1 elemanı var listemin,  2. elemanı ekliyorum ve test başlasın;
            isimler.Add("Kerem");
            Console.WriteLine(isimler.Lenght); //Bingo!
            //Birde elemanları görüntüleyelim;
            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }



        }
    }
}
