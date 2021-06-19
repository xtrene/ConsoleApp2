using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hola Mundo !!!");
            int num1 = 5;
            int nuero2 = 6;
            double numero3 = 2.57;
            double suma;
            suma = num1 + numero3;

            Console.WriteLine(suma);
            string valor1 = Console.ReadLine();
            Console.WriteLine("El número introducido es: " + valor1);

            Console.ReadKey();

        }
    }
}
