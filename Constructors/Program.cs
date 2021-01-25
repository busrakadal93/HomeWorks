using System;

namespace Constructors
{
    class Program
    {
        //Bir classı new lediğimiz zaman çalışan blog
        //bir class ilk kez oluştuğu zaman bir kez çalışır sonra çalışmaz
        //Constructor : Yapıcı Metot
        static void Main(string[] args)
        {
            Customer customer = new Customer(); // bir classı newledik.
            Customer customer1 = new Customer { Id = 1, FirstName = "Büşra", LastName = "Kadal", City = "İstanbul" };
            Customer customer2 = new Customer(2, "Dila", "Kadal", "İstanbul"); //normal parantez görünce metot mantığını düşün
            //Bu şekilde kullanım metotlarda var ve buradaki 4 eleman parametredir.

            Console.WriteLine(customer2.FirstName);

            //customer3 ve customer1 aynı şekilde tanımlamadır.
            Customer customer3 = new Customer();
            customer3.Id = 3;

            //Parametresi olmayan constructera default constructor deniliyor.

            Method(2, "Nihal ve Aziz", "Kadal", "İstanbul");
        }

        static void Method(int id, string firtsName, string lastName, string city)
        {

        }
    }

    class Customer
    {
        public Customer(int id, string firtsName, string lastName, string city)
        {
            Id = id;
            FirstName = firtsName;
            LastName = lastName;
            City = city;
        }
        //default constructor.
        public Customer() //ctor tab tab yapınca
        {
            Console.WriteLine("Yapıcı Blok");
        }



        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
