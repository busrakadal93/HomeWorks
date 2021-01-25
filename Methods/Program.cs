using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mesela veri tabanına bir kaydetme işlemi için metot kullanabiliriz. 
            Add();

            //Add2(5, 3); tek bunu yazarak bişi gözükmez
            var result = Add2(5, 3);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(int number1, int number2=30) //eğer number2 default değer olarak 30u algılar
        {
            var result = number1 + number2;
            return result;
        }
    }
}
