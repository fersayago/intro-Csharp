using System;

namespace NumericCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA;
            int numberB;

            Console.WriteLine("Ingrese el primer numero");
            numberA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            numberB = Convert.ToInt32(Console.ReadLine());

            int resultado = numberA * numberB;

            Console.WriteLine($"Resultado => {resultado}");
        }
    }
}
