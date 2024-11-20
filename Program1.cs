using System;
//Ejercicio 1: Calcular el Factorial de un Número
//Crea un programa en C# que solicite al usuario un número entero y 
// calcule su factorial. Usa un bucle for para realizar el cálculo.
class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número para calcular su factorial: ");
        int numero = int.Parse(Console.ReadLine());
        long factorial = CalcularFactorial(numero);
        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }

    static long CalcularFactorial(int numero)
    {
        long resultado = 1;
        for (int i = 1; i <= numero; i++)
        {
            resultado *= i;
        }
        return resultado;
    }
}
