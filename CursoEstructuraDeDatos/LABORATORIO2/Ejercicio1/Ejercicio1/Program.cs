using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese los dos números
        Console.WriteLine("Ingrese el primer número:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Realizar las operaciones
        double suma = num1 + num2;
        double resta = num1 - num2;
        double multiplicacion = num1 * num2;

        // Asegurarse de que el segundo número no sea cero antes de dividir
        double division = (num2 != 0) ? (num1 / num2) : 0;

        // Mostrar los resultados
        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Resta: " + resta);
        Console.WriteLine("Multiplicación: " + multiplicacion);
        Console.WriteLine("División: " + division);
    }
}

