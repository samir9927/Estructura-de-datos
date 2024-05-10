// 7)	Crea una matriz de números complejos
using System;
using System.Numerics; // Necesario para trabajar con números complejos

class Program
{
    static void Main(string[] args)
    {
        // Crear una matriz de 2x2 de números complejos
        Complex[,] matriz = new Complex[2, 2];

        // Asignar valores a la matriz
        matriz[0, 0] = new Complex(1, 2); // 1 + 2i
        matriz[0, 1] = new Complex(3, 4); // 3 + 4i
        matriz[1, 0] = new Complex(5, 6); // 5 + 6i
        matriz[1, 1] = new Complex(7, 8); // 7 + 8i

        // Imprimir la matriz
        Console.WriteLine("Matriz de números complejos:");
        ImprimirMatriz(matriz);
    }

    static void ImprimirMatriz(Complex[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
