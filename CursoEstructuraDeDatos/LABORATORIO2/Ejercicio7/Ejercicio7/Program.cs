// Calcula la suma de los números pares en un rango especificado por el usuario. 
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el límite inferior del rango:");
        int limiteInferior = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el límite superior del rango:");
        int limiteSuperior = Convert.ToInt32(Console.ReadLine());

        int sumaPares = SumaNumerosPares(limiteInferior, limiteSuperior);

        Console.WriteLine("La suma de los números pares en el rango es: " + sumaPares);
    }

    static int SumaNumerosPares(int inicio, int fin)
    {
        int suma = 0;
        // Asegurarse de que el límite inferior sea par
        if (inicio % 2 != 0)
        {
            inicio++;
        }
        // Sumar los números pares en el rango
        for (int i = inicio; i <= fin; i += 2)
        {
            suma += i;
        }
        return suma;
    }
}
