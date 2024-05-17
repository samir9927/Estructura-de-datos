//Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números primos.
using System;
using System.Collections.Generic;

public class Programa
{
    public static void Main()
    {
        // HashSet para que no haya repetidos
        HashSet<int> numeros = new HashSet<int> { 2, 3, 4, 5, 10, 13, 17, 19, 23, 24 };

        // Obtener los números primos del conjunto
        HashSet<int> numerosPrimos = ObtenerNumerosPrimos(numeros);

        // Imprimir los números primos
        Console.WriteLine("Números primos:");
        foreach (int primo in numerosPrimos)
        {
            Console.WriteLine(primo);
        }
    }

    // Método para obtener los números primos de un conjunto
    public static HashSet<int> ObtenerNumerosPrimos(HashSet<int> numeros)
    {
        // Crear un nuevo conjunto para almacenar los números primos
        HashSet<int> primos = new HashSet<int>();

        // Iterar sobre cada número en el conjunto de entrada
        foreach (int numero in numeros)
        {
            // Si el número es primo, agregarlo al conjunto de primos
            if (EsPrimo(numero))
            {
                primos.Add(numero);
            }
        }

        // Devolver el conjunto de números primos
        return primos;
    }

    // Método para verificar si un número es primo
    private static bool EsPrimo(int numero)
    {
        // Los números menores o iguales a 1 no son primos
        if (numero <= 1) return false;

        // El número 2 es primo
        if (numero == 2) return true;

        // Los números pares mayores que 2 no son primos
        if (numero % 2 == 0) return false;

        // Verificar la divisibilidad solo hasta la raíz cuadrada del número
        for (int i = 3; i <= Math.Sqrt(numero); i += 2)
        {
            // Si el número es divisible por cualquier número en este rango, no es primo
            if (numero % i == 0) return false;
        }

        // Si no se encontró ningún divisor, el número es primo
        return true;
    }
}
