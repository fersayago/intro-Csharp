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

            /* TIPOS DE DATOS
             * int 4 bites almancena informacion -2.147.483.648 to 2.147.483.648
             * bool 1 bit almacena información de o a 1
             * float 4 bytes hasta 6 a 7 digitos
             * double 8 bytes numeros decimales de hasta 15 digitos
             * char 2 bytes almacena un caracter o letra
             * string 2 bytes por caracter, se almacena como una secuencia de caracteres
             * long -9223372036854775808 to 9223372036854775808
             * uint 0 a 4.294.967.295
             */

            double height = 1.7;
            int age = 29;
            string name = "Fernando Sayago";
            string placeholderText = "The information you requested is:";
            string information = $"{placeholderText}\nname: {name}\nage: {age}\nheight: {height}";

            Console.WriteLine(information);

        }
    }
}
