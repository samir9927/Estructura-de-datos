// Crea una lista de los cuadrados de los primeros 10 números naturales
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> cuadrados = new List<int>();

        for (int i = 1; i <= 10; i++)
        {
            cuadrados.Add(i * i);
        }

        Console.WriteLine("Los cuadrados de los primeros 10 números naturales son:");
        foreach (int cuadrado in cuadrados)
        {
            Console.WriteLine(cuadrado);
        }
    }
}

