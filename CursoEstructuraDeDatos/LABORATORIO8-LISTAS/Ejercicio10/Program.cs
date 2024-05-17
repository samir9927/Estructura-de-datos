using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] palabras = { "casa", "perro", "gato", "auto", "azul", "amarillo" };
        char letraDeterminada = 'a';
        HashSet<string> palabrasConLetra = FiltrarPorLetra(palabras, letraDeterminada);

        Console.WriteLine($"Palabras que contienen la letra '{letraDeterminada}' encontradas:");
        foreach (var palabra in palabrasConLetra)
        {
            Console.WriteLine(palabra);
        }
    }

    static HashSet<string> FiltrarPorLetra(string[] palabras, char letra)
    {
        HashSet<string> palabrasFiltradas = new HashSet<string>();

        foreach (string palabra in palabras)
        {
            if (palabra.Contains(letra))
            {
                palabrasFiltradas.Add(palabra);
            }
        }

        return palabrasFiltradas;
    }
}
