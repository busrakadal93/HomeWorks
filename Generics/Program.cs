using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //List bir class
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count); //bunda hiçbişi yok
            

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("İstanbul");
            Console.WriteLine(sehirler2.Count);
            
        }
    }

    class MyList<T> //generic class, classın çalışma tipi T //hangi tipi verirsek ona dönüşüyor T 
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0]; //0 elemanlı bir array
        }
        public void Add(T item)
        {
            //eleman sayısını 1 arttırmak için diziyi newlememiz gerekiyor.
            //_array = new T[_array.Length + 1]; //eleman sayısını 1 arttırma 
            //eleman sayısını 1 arttırınca eski data siliniyor. Çünkü yeni referans alıyorum.

            //o yüzden önceki dataların yedeğini almam lazım yani temparray geçici de tutmam lazım.
            _tempArray = _array; //temparray arrayin refaransını tutuyor.
            _array = new T[_array.Length + 1]; // arrayin eleman sayısını 1 arttırdık.
            //şimdi temparrayi aktarıcaz o yüzden for döngüsü kullandık.
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item; //son olarak neyi eklediysek onu da eklemiş oluyoruz.

        }

        public int Count
        {
            get { return _array.Length; } //Mylistin countu ise arrayin eleman sayısını verecek.
            
        }

    }
}
