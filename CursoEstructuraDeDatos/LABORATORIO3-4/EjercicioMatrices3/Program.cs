// Escribe una función que encuentre el elemento máximo de una matriz. 

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

        // Encontrar el elemento máximo de la matriz
        int maximo = EncontrarMaximo(matriz);

        Console.WriteLine("El elemento máximo de la matriz es: " + maximo);
    }

    static int EncontrarMaximo(int[,] matriz)
    {
        int maximo = int.MinValue;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                if (matriz[i, j] > maximo)
                {
                    maximo = matriz[i, j];
                }
            }
        }
        return maximo;
    }
}
