using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] palabras = { "casa", "perro", "gato", "auto", "azul", "amarillo" };
        int longitudDeseada = 4;
        HashSet<string> palabrasConLongitudOrdenadas = FiltrarPorLongitudOrdenadas(palabras, longitudDeseada);

        Console.WriteLine($"Palabras de longitud {longitudDeseada} ordenadas encontradas:");
        foreach (var palabra in palabrasConLongitudOrdenadas)
        {
            Console.WriteLine(palabra);
        }
    }

    static HashSet<string> FiltrarPorLongitudOrdenadas(string[] palabras, int longitud)
    {
        HashSet<string> palabrasFiltradas = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (palabra.Length == longitud)
            {
                palabrasFiltradas.Add(palabra);
            }
        }

        return OrdenarConjunto(palabrasFiltradas);
    }

    static HashSet<string> OrdenarConjunto(HashSet<string> conjunto)
    {
        List<string> listaOrdenada = conjunto.ToList();
        listaOrdenada.Sort();
        return new HashSet<string>(listaOrdenada);
    }
}
