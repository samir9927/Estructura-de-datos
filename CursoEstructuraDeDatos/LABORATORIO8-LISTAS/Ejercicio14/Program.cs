using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 5, 2, 8, 1, 6, 3, 5, 2, 8 };
        HashSet<int> numerosNoDuplicados = EncontrarNoDuplicados(numeros);

        Console.WriteLine("Números no duplicados encontrados:");
        foreach (var numero in numerosNoDuplicados)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> EncontrarNoDuplicados(int[] numeros)
    {
        HashSet<int> numerosVistos = new HashSet<int>();
        HashSet<int> numerosDuplicados = new HashSet<int>();

        foreach (int numero in numeros)
        {
            // Si el número ya ha sido visto, lo agregamos a los duplicados
            if (!numerosVistos.Add(numero))
            {
                numerosDuplicados.Add(numero);
            }
        }

        // Creamos un conjunto para almacenar los números no duplicados
        HashSet<int> numerosNoDuplicados = new HashSet<int>();

        foreach (int numero in numeros)
        {
            // Si el número no está en la lista de duplicados, lo agregamos a los no duplicados
            if (!numerosDuplicados.Contains(numero))
            {
                numerosNoDuplicados.Add(numero);
            }
        }

        return numerosNoDuplicados;
    }
}
