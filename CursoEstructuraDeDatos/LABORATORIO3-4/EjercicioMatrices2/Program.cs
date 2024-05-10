// Calcula la media, la mediana y la desviación estándar de los elementos de una matriz. 
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Ejemplo de matriz 3x3, puedes modificarla según tus necesidades
        int[,] matriz = {
            {10, 20, 30},
            {40, 50, 60},
            {70, 80, 90}
        };

        // Obtener una lista de todos los elementos de la matriz
        int totalElementos = matriz.GetLength(0) * matriz.GetLength(1);
        int[] elementos = new int[totalElementos];
        int index = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                elementos[index++] = matriz[i, j];
            }
        }

        // Calcular la media
        double media = elementos.Average();

        // Calcular la mediana
        Array.Sort(elementos);
        double mediana;
        if (totalElementos % 2 == 0)
        {
            mediana = (elementos[totalElementos / 2 - 1] + elementos[totalElementos / 2]) / 2.0;
        }
        else
        {
            mediana = elementos[totalElementos / 2];
        }

        // Calcular la desviación estándar
        double sumaCuadradosDiferencias = 0;
        foreach (int elemento in elementos)
        {
            sumaCuadradosDiferencias += Math.Pow(elemento - media, 2);
        }
        double desviacionEstandar = Math.Sqrt(sumaCuadradosDiferencias / totalElementos);

        // Mostrar los resultados
        Console.WriteLine("Media: " + media);
        Console.WriteLine("Mediana: " + mediana);
        Console.WriteLine("Desviación estándar: " + desviacionEstandar);
    }
}

