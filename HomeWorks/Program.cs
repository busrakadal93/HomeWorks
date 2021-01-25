using System;

namespace HomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(başlangıç değeri ; koşul ; değişim miktarı){
            //komutlar
            //}
            //Genel kullanımı bu şekildedir. Koşul sağlandıkça değişim miktarına bağlı olarak döngü devam edecektir.

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i); //0-10 sayıları ekrana yazdırır.
            //}
            //Console.ReadLine();

            //if (şart)
            //{
            //  doğruysa yapılacak işlemler
            // }
            //else if (şart)
            //{
            //  buradaki şart doğruysa yapılacak işlemler
            //}
            //else
            //{
            //  yanlışsa yapılacak işlemler
            //}
            //Genel kullanımı bu şekildedir. Hangi şart sağlanırsa o blok çalışır. Şartların sağlanmadığı kısımda else çalışır.

            //Console.WriteLine("Notunuzu giriniz: ");
            //int a = int.Parse(Console.ReadLine());
            //if (a<50)
            //{
            //    Console.WriteLine("Kaldınız");
            //}
            //else
            //{
            //    Console.WriteLine("Geçtiniz");
            //}
            //Console.ReadLine();

            //while(şartımız)
            //{
            //  şart sağlandığı sürece buradaki işlemler tekrarlanır.
            //}
            //Genelde döngünün kaç kez döneceğini tahmin edemediğimiz durumlarda kullanılır.En başta belirtilen şart tutmaz ise döngü hiç
            //dönmeyebilir, tutması halinde defalarca dönebilir.

            //int sayi = 0;
            //while (sayi <= 10)
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //}
            //Console.ReadLine();

            //do
            //{
            //  işlemler
            //}
            //while(döngünün çalışma koşulu);
            //Bu döngüde while da olduğu gibi döngünün kaç kez döndüğünü bilmediğmiz durumlarda kullanılır.
            //While döngüsünden en önemli farkı şartın döngünün sonunda kontrol edilmesidir. Bu nedenle de do while döngüsünü kullandığımızda
            //döngü içerisindeki işlemler en az bir kere yapılacak demektir.

            //int sayi2 = 0;
            //do
            //{
            //    Console.WriteLine(sayi2);
            //    sayi2++;
            //} while (sayi2 <= 10);
            //Console.ReadLine();

            //Single Line If ile çalışmak (tek satır if else kodu gibi düşün)
            var sayi3 = 11;
            Console.WriteLine(sayi3 == 10 ? "Sayımız 10" : "Sayımız 10 değil");
            Console.ReadLine();
        }
    }
}
