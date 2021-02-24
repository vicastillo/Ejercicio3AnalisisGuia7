using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soloapoyo
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();

        Console.Title = "Programa que muestra los números pares que existen entre los 2 numeros ingresados.";

        Console.WriteLine("Ingrese el primer número:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número:");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Los números pares entre " + num1 + " y " + num2 + " son:");

        if (num1 > num2)
        {
            Console.WriteLine("El número 2 debe ser mayor que el número 1");
            return;
        }

        int contador = num1;

        while (contador <= num2)
        {
            if (contador % 2 == 0)
            {
            Console.WriteLine(+ contador);
            }

            contador++;

        }
        Console.ReadKey();
        }
    }
}
