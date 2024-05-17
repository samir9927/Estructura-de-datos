using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 5, 2, 8, 1, 6, 3 };
        HashSet<int> numerosOrdenados = FiltrarOrdenados(numeros);

        Console.WriteLine("Números ordenados encontrados:");
        foreach (var numero in numerosOrdenados)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> FiltrarOrdenados(int[] numeros)
    {
        HashSet<int> numerosFiltrados = new HashSet<int>();

        for (int i = 0; i < numeros.Length; i++)
        {
            bool esOrdenado = true;
            for (int j = i + 1; j < numeros.Length; j++)
            {
                if (numeros[j] < numeros[i])
                {
                    esOrdenado = false;
                    break;
                }
            }
            if (esOrdenado)
            {
                numerosFiltrados.Add(numeros[i]);
            }
        }

        return numerosFiltrados;
    }
}
