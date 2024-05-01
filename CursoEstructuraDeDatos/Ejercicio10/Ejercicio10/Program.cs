// Genera los primeros 10 números de la serie Fibonacci. 
using System;

class Program
{
    static void Main()
    {
        int cantidadNumeros = 10;
        Console.WriteLine("Los primeros " + cantidadNumeros + " números de la serie Fibonacci son:");

        for (int i = 0; i < cantidadNumeros; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        int anterior = 0;
        int actual = 1;
        int resultado = 0;

        for (int i = 2; i <= n; i++)
        {
            resultado = anterior + actual;
            anterior = actual;
            actual = resultado;
        }

        return resultado;
    }
}
