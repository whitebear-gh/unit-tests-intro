using System;

namespace console_app
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("I want to tell you bro if your number is prime or not");
            var line = Console.ReadLine();
            var number = int.Parse(line);
            var ps = new PrimeService();
            var result = ps.IsPrime(number);
            if(result){
                Console.WriteLine("Prime! ");
            }
            else{
                Console.WriteLine("Not Prime! ");
            }

        }
    }
}
