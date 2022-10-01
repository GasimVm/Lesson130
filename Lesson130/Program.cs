using System;

namespace Lesson130
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Senin nece yasin var?");
            string userInput = Console.ReadLine();
            
            var age = Int32.Parse(userInput);
            Console.WriteLine("Senin nece yasin var?");
            string userInput2 = Console.ReadLine();
            int b = age - 10;

            Console.WriteLine($"Senin bu qeder yaSIN VAR : {b}");
            
             
             
        }

       
    }
}
