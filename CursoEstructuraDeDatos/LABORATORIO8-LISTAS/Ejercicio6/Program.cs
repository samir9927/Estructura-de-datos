// Escriba una función que reciba dos conjuntos de números y
// devuelva un conjunto con los números que están en el segundo conjunto pero no en el primero.
using System;
using System.Collections.Generic;

public class Programa
{
    public static void Main()
    {
        List<int> conjunto1 = new List<int> { 1, 2, 3, 4, 5, 6 };
        List<int> conjunto2 = new List<int> { 4, 5, 6, 7, 8, 9 };

        List<int> diferencia = ObtenerDiferencia(conjunto2, conjunto1);

        Console.WriteLine("Números en el segundo conjunto pero no en el primero:");
        foreach (int numero in diferencia)
        {
            Console.WriteLine(numero);
        }
    }

    public static List<int> ObtenerDiferencia(List<int> conjuntoA, List<int> conjuntoB)
    {
        List<int> diferencia = new List<int>();

        foreach (int numero in conjuntoA)
        {
            //El método Contains en C# es una función que se utiliza para verificar si un
            //elemento específico está presente en una colección, como una lista.
            if (!conjuntoB.Contains(numero))
            {
                diferencia.Add(numero);
            }
        }

        return diferencia;
    }
}
