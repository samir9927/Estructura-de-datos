using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] palabras = { "casa", "perro", "gato", "auto", "azul", "amarillo" };
        char letraDeterminada = 'a';
        HashSet<string> palabrasConLetraOrdenadas = FiltrarPorLetraOrdenadas(palabras, letraDeterminada);

        Console.WriteLine($"Palabras que contienen la letra '{letraDeterminada}' ordenadas encontradas:");
        foreach (var palabra in palabrasConLetraOrdenadas)
        {
            Console.WriteLine(palabra);
        }
    }

    static HashSet<string> FiltrarPorLetraOrdenadas(string[] palabras, char letra)
    {
        HashSet<string> palabrasFiltradas = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (palabra.Contains(letra))
            {
                palabrasFiltradas.Add(palabra);
            }
        }

        return OrdenarConjuntoDescendente(palabrasFiltradas);
    }

    static HashSet<string> OrdenarConjuntoDescendente(HashSet<string> conjunto)
    {
        List<string> listaOrdenada = conjunto.ToList();
        listaOrdenada.Sort((a, b) => string.Compare(b, a));
        return new HashSet<string>(listaOrdenada);
    }
}
