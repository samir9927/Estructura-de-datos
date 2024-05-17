//Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números que son
//divisibles por un número determinado.

using System;
using System.Collections.Generic;

public class Programa
{
    public static void Main()
    {
        HashSet<int> numeros = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 15, 18, 20 };
        int divisor = 3;
        HashSet<int> numerosDivisibles = ObtenerNumerosDivisiblesPor(numeros, divisor);

        Console.WriteLine($"Números divisibles por {divisor}:");
        foreach (int numero in numerosDivisibles)
        {
            Console.WriteLine(numero);
        }
    }

    public static HashSet<int> ObtenerNumerosDivisiblesPor(HashSet<int> numeros, int divisor)
    {
        HashSet<int> numerosDivisibles = new HashSet<int>();

        foreach (int numero in numeros)
        {
            if (numero % divisor == 0)
            {
                numerosDivisibles.Add(numero);
            }
        }

        return numerosDivisibles;
    }
}
