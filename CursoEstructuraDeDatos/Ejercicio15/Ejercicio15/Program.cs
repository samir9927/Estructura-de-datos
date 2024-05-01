// Toma un número entero y calcula la suma de sus dígitos. 
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número entero:");
        int numero = Convert.ToInt32(Console.ReadLine());

        int sumaDigitos = CalcularSumaDigitos(numero);

        Console.WriteLine("La suma de los dígitos de " + numero + " es: " + sumaDigitos);
    }

    static int CalcularSumaDigitos(int numero)
    {
        int suma = 0;

        // Iterar a través de cada dígito del número y sumarlo
        while (numero != 0)
        {
            suma += numero % 10;
            numero /= 10;
        }

        return suma;
    }
}

