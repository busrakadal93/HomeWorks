using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, decimal, float, enum, boolean sayısal olan değişkenler değer tiptir. yani value types
            //Bellekte stackte tutuyor değeri atayıp unutuyor.

            int sayi1 = 10; //sayi1 i 10 olarak tanımladık
            int sayi2 = 20; //sayi2 yi 20 olarak tanımladık

            sayi1 = sayi2; //sayi1 in değerine sayi2 nin değerini atadık yani 20 yi
            sayi2 = 100; // sayi2 ye 100 değerini atadık.
            Console.WriteLine("Sayi 1 : " + sayi1); //sayi1 e 20 yi atamıştık o yüzden cevap 20


            //arrays, class, interface... referans tiptir. reference types
            //Stack burada da var ama değeri heap de tutuyor 

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2; //sayilar1 in adresi = sayilar2 nin adresi diye okunur. 
            sayilar2[0] = 1000; //sayilar2 nin adresinin 0.elemanı 10 değilde 100 oluyor.

            Console.WriteLine("Sayilar1[0] : " + sayilar1[0]); //sayilar1 in adresinin 0.elemanını soruyor. Yukarıda sayilar2ye atadığımız için sonuç 1000

            Console.WriteLine("-------------------------------------------");

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1; //person2 ninde first name engin olur. Burada değer eşitlemesi değil, adres eşitlemesi yapıyoruz.
            person1.FirstName = "Büşra"; //

            Console.WriteLine(person2.FirstName); //Büşra olarak değişir.

            Customer customer = new Customer();
            customer.FirstName = "Dila";
            customer.CreditCardNumber = "12345678910";

            Employee employee = new Employee();
            employee.FirstName = "Nihal ve Aziz";

            Person person3 = customer; //miras aldığımız sınıf türünde birşeye mirası alan classı atayabiliriz.
            //Person:base class (ebeveyndir.)
            Console.WriteLine(person3.FirstName); //Dila yazacak
            Console.WriteLine(((Customer)person3).CreditCardNumber); //person3 de CreditCardNumber yoktur. Tipini değiştirdik.

            PersonManager personManager = new PersonManager();
            personManager.Add3(person3);
            personManager.Add3(customer);
            personManager.Add3(employee);

            

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Customer customer) // sadece Customer çalışırız.
        {

        }
        public void Add2(Employee employee) // sadece Employee çalışırız.
        {

        }
        public void Add3(Person person) // Hem Customer hemde Employee çalışırız. 
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
