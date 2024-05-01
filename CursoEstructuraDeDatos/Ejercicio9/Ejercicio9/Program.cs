// Cuenta el número de vocales en una cadena de texto. 
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una cadena de texto:");
        string texto = Console.ReadLine();

        int contadorVocales = ContarVocales(texto);

        Console.WriteLine("El número de vocales en la cadena es: " + contadorVocales);
    }

    static int ContarVocales(string texto)
    {
        int contador = 0;
        foreach (char c in texto.ToLower())
        {
            if ("aeiou".Contains(c))
            {
                contador++;
            }
        }
        return contador;
    }
}
