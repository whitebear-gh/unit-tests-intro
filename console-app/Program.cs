using System;

namespace console_app
{
    class Program
    {

        public static bool IsPrime(int number){
            if(number == 1 ) return false;
            if(number == 2 ) return false;
            else return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("I want to tell you bro if your number is prime or not");
            var line = Console.ReadLine();
            var number = int.Parse(line);
            var result = IsPrime(number);
            if(result){
                Console.WriteLine("Prime! ");
            }
            else{
                Console.WriteLine("Not Prime! ");
            }

        }
    }
}
