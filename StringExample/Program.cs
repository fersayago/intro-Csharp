using System;

namespace StringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write fullname: ");
            string fullUserName = Console.ReadLine();

            Console.WriteLine($"Hello {fullUserName}, welcome to Platzi");
        }
    }
}
