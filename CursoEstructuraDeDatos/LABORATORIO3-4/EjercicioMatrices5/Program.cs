// Escribe una función que encuentre la matriz de covarianza de dos matrices.
using System;

class Program
{
    static void Main()
    {
        // Ejemplo de dos matrices 3x3, puedes modificarlas según tus necesidades
        double[,] matriz1 = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        double[,] matriz2 = {
            {9, 8, 7},
            {6, 5, 4},
            {3, 2, 1}
        };

        // Encontrar la matriz de covarianza
        double[,] matrizCovarianza = EncontrarMatrizCovarianza(matriz1, matriz2);

        // Imprimir la matriz de covarianza
        Console.WriteLine("Matriz de covarianza:");
        ImprimirMatriz(matrizCovarianza);
    }

    static double[,] EncontrarMatrizCovarianza(double[,] matriz1, double[,] matriz2)
    {
        int filas = matriz1.GetLength(0);
        int columnas = matriz1.GetLength(1);

        // Verificar que las dimensiones de las dos matrices sean las mismas
        if (filas != matriz2.GetLength(0) || columnas != matriz2.GetLength(1))
        {
            throw new ArgumentException("Las dimensiones de las matrices no son compatibles.");
        }

        // Calcular la media de cada matriz
        double mediaMatriz1 = CalcularMedia(matriz1);
        double mediaMatriz2 = CalcularMedia(matriz2);

        // Inicializar la matriz de covarianza
        double[,] matrizCovarianza = new double[filas, columnas];

        // Calcular la covarianza para cada par de elementos correspondientes en las dos matrices
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matrizCovarianza[i, j] = (matriz1[i, j] - mediaMatriz1) * (matriz2[i, j] - mediaMatriz2);
            }
        }

        return matrizCovarianza;
    }

    static double CalcularMedia(double[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        double suma = 0;

        // Calcular la suma de todos los elementos de la matriz
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                suma += matriz[i, j];
            }
        }

        // Calcular la media dividiendo la suma total por el número de elementos
        return suma / (filas * columnas);
    }

    static void ImprimirMatriz(double[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
