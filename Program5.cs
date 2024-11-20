using System;
using System.Net;

class Program
{
//    Ejercicio 5: Números Primos en un Rango
//Crea un programa que pida dos números enteros y muestre todos los números primos entre ellos.
    static void Main()
    {
        Console.Write("Ingrese el inicio del rango: ");
        int inicio = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el final del rango: ");
        int final = int.Parse(Console.ReadLine());

        Console.WriteLine("Números primos en el rango:");
        for (int i = inicio; i <= final; i++)
        {
            if (EsPrimo(i))
            {
                Console.WriteLine(i);
            }
        }
    }

    static bool EsPrimo(int numero)
    {
        if (numero <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0) return false;
        }
        return true;
    }
}
