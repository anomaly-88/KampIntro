using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        //Constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];

            //Yeni Array'ımın i. elemanı = Eski array'ımın i. elemanı. i, yeni Array'ımın uzunluğu -1 olana kadar gidecek, 
            //i ve index numaraları 0'dan, lenght yani uzunluk saymaya 1'den başladığı için bir sorun oluşmadan bu işlem tamamlanacak.
            //bu işin kısa yolu da var, bu algoritmik yolu.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            // ve dizi eşleme işleminden sonra son elemanı ekleyebilirim;
            // items'in kaçıncı index'ine eklemek istediğimi belirtip parametre ile aldığım değeri o index'e eşitliyorum.
            items[items.Length - 1] = item;
        }


        //Aşağıya yazacaklarım Önümüzdeki haftanın konusu, sadece bunu test etmek için yapıyorum, siz yazmayın.
        //Mia: Bu arada editörde Alt+yukarı/aşağı -> kod satırını kaydırıyor | ctrl+yukarı/aşağı -> sayfayı kaydırıyor.
        public int Lenght
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }

    }
}
