// Pide el radio de un círculo al usuario y calcula su área
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el radio del círculo:");
        double radio = Convert.ToDouble(Console.ReadLine());

        double area = CalcularAreaCirculo(radio);

        Console.WriteLine("El área del círculo con radio " + radio + " es: " + area);
    }

    static double CalcularAreaCirculo(double radio)
    {
        return Math.PI * radio * radio;
    }
}
