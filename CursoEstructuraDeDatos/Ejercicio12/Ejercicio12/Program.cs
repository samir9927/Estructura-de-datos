// Verifica si una palabra ingresada por el usuario es un palíndromo. 
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una palabra para verificar si es un palíndromo:");
        string palabra = Console.ReadLine();

        if (EsPalindromo(palabra))
        {
            Console.WriteLine("La palabra \"" + palabra + "\" es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La palabra \"" + palabra + "\" no es un palíndromo.");
        }
    }

    static bool EsPalindromo(string palabra)
    {
        int longitud = palabra.Length;
        for (int i = 0; i < longitud / 2; i++)
        {
            if (palabra[i] != palabra[longitud - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}

