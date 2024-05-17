using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] palabras = { "reconocer", "oso", "casa", "radar", "sol", "ana" };
        HashSet<string> palindromos = EncontrarPalindromos(palabras);

        Console.WriteLine("Palíndromos encontrados:");
        foreach (var palindromo in palindromos)
        {
            Console.WriteLine(palindromo);
        }
    }

    static HashSet<string> EncontrarPalindromos(string[] palabras)
    {
        HashSet<string> palindromos = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (EsPalindromo(palabra))
            {
                palindromos.Add(palabra);
            }
        }

        return palindromos;
    }

    static bool EsPalindromo(string palabra)
    {
        int longitud = palabra.Length;
        for (int i = 0; i < longitud / 2; i++)
        {
            if (palabra[i] != palabra[longitud - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
