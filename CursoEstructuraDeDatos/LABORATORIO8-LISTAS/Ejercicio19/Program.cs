using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 5, 2, 8, 1, 6, 3, 5, 2, 8 };
        HashSet<int> numerosOrdenadosNoDuplicados = OrdenarYEliminarDuplicados(numeros);

        Console.WriteLine("Números ordenados y no duplicados encontrados:");
        foreach (var numero in numerosOrdenadosNoDuplicados)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> OrdenarYEliminarDuplicados(int[] numeros)
    {
        // Eliminar duplicados
        HashSet<int> numerosUnicos = new HashSet<int>();
        foreach (int numero in numeros)
        {
            numerosUnicos.Add(numero);
        }

        // Ordenar
        List<int> numerosOrdenados = new List<int>(numerosUnicos);
        numerosOrdenados.Sort();

        return new HashSet<int>(numerosOrdenados);
    }
}
