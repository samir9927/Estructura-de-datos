using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 5, 2, 8, 1, 6, 3, 5, 2, 8 };
        HashSet<int> numerosDuplicados = EncontrarDuplicados(numeros);

        Console.WriteLine("Números duplicados encontrados:");
        foreach (var numero in numerosDuplicados)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> EncontrarDuplicados(int[] numeros)
    {
        HashSet<int> numerosVistos = new HashSet<int>();
        HashSet<int> numerosDuplicados = new HashSet<int>();

        foreach (int numero in numeros)
        {
            // Si el número ya ha sido visto, es un duplicado
            if (!numerosVistos.Add(numero))
            {
                numerosDuplicados.Add(numero);
            }
        }

        return numerosDuplicados;
    }
}
