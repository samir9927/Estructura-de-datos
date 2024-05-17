using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] palabras = { "oso", "casa", "radar", "reconocer", "sol", "ana", "aviva" };
        int longitudDeseada = 3;
        HashSet<string> palabrasPalindromasOrdenadas = FiltrarPorLongitudPalindromosOrdenadas(palabras, longitudDeseada);

        Console.WriteLine($"Palíndromos de longitud {longitudDeseada} y ordenados encontrados:");
        foreach (var palabra in palabrasPalindromasOrdenadas)
        {
            Console.WriteLine(palabra);
        }
    }

    static HashSet<string> FiltrarPorLongitudPalindromosOrdenadas(string[] palabras, int longitud)
    {
        HashSet<string> palabrasFiltradas = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (palabra.Length == longitud && EsPalindromo(palabra))
            {
                palabrasFiltradas.Add(palabra);
            }
        }

        return OrdenarConjunto(palabrasFiltradas);
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
