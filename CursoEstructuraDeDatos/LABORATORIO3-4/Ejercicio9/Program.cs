// 9)	Accede al elemento central de una matriz. using System;

class Program
{
    static void Main()
    {
        int[,] matriz = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        int filaCentral = filas / 2;
        int columnaCentral = columnas / 2;

        int elementoCentral = matriz[filaCentral, columnaCentral];

        Console.WriteLine("Elemento central: " + elementoCentral);
    }
}

