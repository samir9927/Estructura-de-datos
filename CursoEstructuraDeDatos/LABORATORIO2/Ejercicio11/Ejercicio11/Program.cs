// Ordena una lista de números ingresados por el usuario de menor a mayor. 
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese los números separados por espacios:");
        string input = Console.ReadLine();

        string[] numerosString = input.Split(' ');
        int[] numeros = new int[numerosString.Length];

        for (int i = 0; i < numerosString.Length; i++)
        {
            numeros[i] = Convert.ToInt32(numerosString[i]);
        }

        OrdenarNumeros(numeros);

        Console.WriteLine("Lista ordenada de menor a mayor:");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }
    }

    static void OrdenarNumeros(int[] numeros)
    {
        Array.Sort(numeros);
    }
}

