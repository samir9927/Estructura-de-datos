using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese una cadena de texto:");
        string texto = Console.ReadLine();

        string textoInvertido = InvertirTexto(texto);

        Console.WriteLine("La cadena invertida es: " + textoInvertido);
    }

    static string InvertirTexto(string texto)
    {
        char[] caracteres = texto.ToCharArray();
        Array.Reverse(caracteres);
        return new string(caracteres);
    }
}
