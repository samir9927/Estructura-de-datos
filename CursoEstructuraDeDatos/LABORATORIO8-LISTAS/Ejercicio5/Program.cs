// 5.	Escriba una función que reciba dos conjuntos de números y devuelva un conjunto con los números
// que están en el primer conjunto pero no en el segundo. 

using System;
using System.Collections.Generic;

public class Programa
{
    public static void Main()
    {
        List<int> conjunto1 = new List<int> { 1, 2, 3, 4, 5, 6 };
        List<int> conjunto2 = new List<int> { 4, 5, 6, 7, 8, 9 };

        List<int> diferencia = ObtenerDiferencia(conjunto1, conjunto2);

        Console.WriteLine("Números en el primer conjunto pero no en el segundo:");
        foreach (int numero in diferencia)
        {
            Console.WriteLine(numero);
        }
    }

    public static List<int> ObtenerDiferencia(List<int> conjunto1, List<int> conjunto2)
    {
        List<int> diferencia = new List<int>();

        foreach (int numero in conjunto1)
        {
            if (!conjunto2.Contains(numero))
            {
                diferencia.Add(numero);
            }
        }

        return diferencia;
    }
}

