using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] palabras = { "casa", "perro", "gato", "auto", "azul", "amarillo" };
        int longitudDeseada = 4;
        HashSet<string> palabrasConLongitud = FiltrarPorLongitud(palabras, longitudDeseada);

        Console.WriteLine($"Palabras de longitud {longitudDeseada} encontradas:");
        foreach (var palabra in palabrasConLongitud)
        {
            Console.WriteLine(palabra);
        }
    }

    static HashSet<string> FiltrarPorLongitud(string[] palabras, int longitud)
    {
        HashSet<string> palabrasFiltradas = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (palabra.Length == longitud)
            {
                palabrasFiltradas.Add(palabra);
            }
        }

        return palabrasFiltradas;
    }
}
