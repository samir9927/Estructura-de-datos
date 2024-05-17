using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 5, 12, 7, 3, 8, 11, 13 };
        HashSet<int> numerosPrimosOrdenados = EncontrarPrimosOrdenados(numeros);

        Console.WriteLine("Números primos ordenados encontrados:");
        foreach (var numero in numerosPrimosOrdenados)
        {
            Console.WriteLine(numero);
        }
    }

    static HashSet<int> EncontrarPrimosOrdenados(int[] numeros)
    {
        HashSet<int> numerosPrimos = new HashSet<int>();

        foreach (int numero in numeros)
        {
            if (EsPrimo(numero))
            {
                numerosPrimos.Add(numero);
            }
        }

        return OrdenarConjunto(numerosPrimos);
    }

    static bool EsPrimo(int numero)
    {
        if (numero <= 1)
        {
            return false;
        }
        if (numero == 2 || numero == 3)
        {
            return true;
        }
        if (numero % 2 == 0)
        {
            return false;
        }

        int limite = (int)Math.Sqrt(numero);
        for (int i = 3; i <= limite; i += 2)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static HashSet<int> OrdenarConjunto(HashSet<int> conjunto)
    {
        List<int> listaOrdenada = new List<int>(conjunto);
        listaOrdenada.Sort();
        return new HashSet<int>(listaOrdenada);
    }
}
