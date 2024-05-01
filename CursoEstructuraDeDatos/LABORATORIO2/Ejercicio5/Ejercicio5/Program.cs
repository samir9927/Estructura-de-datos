using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un número para verificar si es primo:");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (EsPrimo(numero))
        {
            Console.WriteLine(numero + " es un número primo.");
        }
        else
        {
            Console.WriteLine(numero + " no es un número primo.");
        }
    }

    static bool EsPrimo(int num)
    {
        if (num <= 1)
        {
            return false;
        }

        // Verificar si el número es divisible por algún número entre 2 y su raíz cuadrada
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
