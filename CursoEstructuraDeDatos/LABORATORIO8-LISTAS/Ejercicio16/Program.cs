using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] palabras = { "oso", "casa", "radar", "reconocer", "sol", "ana", "aviva" };
        HashSet<string> palabrasPalindromasOrdenadas = EncontrarPalindromasOrdenadas(palabras);

        Console.WriteLine("Palabras palíndromas ordenadas encontradas:");
        foreach (var palabra in palabrasPalindromasOrdenadas)
        {
            Console.WriteLine(palabra);
        }
    }

    static HashSet<string> EncontrarPalindromasOrdenadas(string[] palabras)
    {
        HashSet<string> palabrasPalindromas = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (EsPalindromo(palabra))
            {
                palabrasPalindromas.Add(palabra);
            }
        }

        return OrdenarConjunto(palabrasPalindromas);
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

    static HashSet<string> OrdenarConjunto(HashSet<string> conjunto)
    {
        List<string> listaOrdenada = new List<string>(conjunto);
        listaOrdenada.Sort();
        return new HashSet<string>(listaOrdenada);
    }
}
