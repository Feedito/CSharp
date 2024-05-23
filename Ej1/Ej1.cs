﻿using System;

namespace Ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App para realizar el promedio de 3 numeros, presiona enter para continuar... ");
            Console.ReadLine();
            Console.WriteLine("Ingrese el primer número:");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número:");
            double n3 = Convert.ToDouble(Console.ReadLine());

            double promedio = (n1 + n2 + n3) / 3;

            Console.WriteLine("El promedio es: " + promedio);
        }
    }
}