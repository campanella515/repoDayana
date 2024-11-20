using System;

class Program
{
//    Ejercicio 2: Calcular la Media de Números Introducidos
//Escribe un programa que permita al usuario ingresar una cantidad indefinida de 
//        números.Cuando el usuario ingrese "0", 
//        el programa debe mostrar el promedio de los números ingresados.
    static void Main()
    {
        int suma = 0, contador = 0;
        int numero;

        do
        {
            Console.Write("Ingrese un número (0 para terminar): ");
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                suma += numero;
                contador++;
            }

        } while (numero != 0);

        if (contador > 0)
        {
            double promedio = (double)suma / contador;
            Console.WriteLine($"El promedio es: {promedio:F2}");
        }
        else
        {
            Console.WriteLine("No se ingresaron números.");
        }
    }
}
