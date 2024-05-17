// Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que comienzan con una letra determinada.
using System;
using System.Collections.Generic;

public class Programa
{
    public static void Main()
    {
        // Crear un conjunto de palabras
        HashSet<string> palabras = new HashSet<string> { "manzana", "mango", "pera", "plátano", "melón", "sandía" };

        // Definir la letra inicial
        char letraInicial = 'm';

        // Obtener las palabras que comienzan con la letra determinada
        HashSet<string> palabrasFiltradas = ObtenerPalabrasQueComienzanConLetra(palabras, letraInicial);

        // Imprimir las palabras filtradas
        Console.WriteLine($"Palabras que comienzan con '{letraInicial}':");
        foreach (string palabra in palabrasFiltradas)
        {
            Console.WriteLine(palabra);
        }
    }

    // Método para obtener las palabras que comienzan con una letra determinada
    public static HashSet<string> ObtenerPalabrasQueComienzanConLetra(HashSet<string> palabras, char letra)
    {
        // Crear un nuevo conjunto para almacenar las palabras que comienzan con la letra especificada
        HashSet<string> palabrasFiltradas = new HashSet<string>();

        // Iterar sobre cada palabra en el conjunto de entrada
        foreach (string palabra in palabras)
        {
            // Si la palabra comienza con la letra especificada, agregarla al conjunto de palabras filtradas
            if (palabra.StartsWith(letra.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                palabrasFiltradas.Add(palabra);
            }
        }

        // Devolver el conjunto de palabras filtradas
        return palabrasFiltradas;
    }
}
