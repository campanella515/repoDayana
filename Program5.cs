using System;
//Calcular el Mínimo y Máximo en un Array
//Escribe un programa que permita al usuario ingresar varios números 
//    y luego determine el valor mínimo y máximo.
class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de números: ");
        int cantidad = int.Parse(Console.ReadLine());

        int[] numeros = new int[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int min = int.MaxValue, max = int.MinValue;

        foreach (int num in numeros)
        {
            if (num < min) min = num;
            if (num > max) max = num;
        }

        Console.WriteLine($"Mínimo: {min}");
        Console.WriteLine($"Máximo: {max}");
    }
}
