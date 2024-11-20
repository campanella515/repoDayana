using System;
//Ejercicio 4: Contar Vocales en una Cadena
//Escribe un programa que permita al usuario 
//ingresar una cadena y cuente el número de vocales en ella.
class Program
{
    static void Main()
    {
        Console.Write("Ingrese una cadena: ");
        string cadena = Console.ReadLine();

        int cantidadVocales = ContarVocales(cadena);
        Console.WriteLine($"La cadena tiene {cantidadVocales} vocales.");
    }

    static int ContarVocales(string cadena)
    {
        int contador = 0;
        foreach (char c in cadena.ToLower())
        {
            if ("aeiou".Contains(c))
            {
                contador++;
            }
        }
        return contador;
    }
}
