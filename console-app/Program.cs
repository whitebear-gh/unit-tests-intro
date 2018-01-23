using System;

namespace console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I want to tell you bro if your number is prime or not");
            var line = Console.ReadLine();
            var result = int.Parse(line);
            if(result == 1 ){
                Console.WriteLine("Prime! ");
            }
            else{
                Console.WriteLine("Not Prime! ");
            }

        }
    }
}
