using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] palabras = { "amor", "roma", "casa", "saca", "perro", "roper" };
        HashSet<string> anagramas = EncontrarAnagramas(palabras);

        Console.WriteLine("Anagramas encontrados:");
        foreach (var anagrama in anagramas)
        {
            Console.WriteLine(anagrama);
        }
    }

    static HashSet<string> EncontrarAnagramas(string[] palabras)
    {
        HashSet<string> anagramas = new HashSet<string>();

        // Agrupar las palabras por su forma ordenada de letras y filtrar aquellas con más de una palabra
        var gruposAnagramas = palabras.GroupBy(p => new string(p.OrderBy(c => c).ToArray()))
                                      .Where(g => g.Count() > 1);

        // Agregar las palabras de los grupos al conjunto de anagramas
        foreach (var grupo in gruposAnagramas)
        {
            anagramas.UnionWith(grupo);
        }

        return anagramas;
    }
}
