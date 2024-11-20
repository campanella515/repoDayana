using System;
//Ejercicio 3: Convertir Temperatura de Celsius a Fahrenheit y Kelvin
//Crea un programa que solicite una temperatura en grados Celsius y 
// convierta dicha temperatura a Fahrenheit y Kelvin.
class Program
{
    static void Main()
    {
        Console.Write("Ingrese la temperatura en Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = CelsiusAFahrenheit(celsius);
        double kelvin = CelsiusAKelvin(celsius);

        Console.WriteLine($"Fahrenheit: {fahrenheit:F2}");
        Console.WriteLine($"Kelvin: {kelvin:F2}");
    }

    static double CelsiusAFahrenheit(double celsius) => (celsius * 9 / 5) + 32;
    static double CelsiusAKelvin(double celsius) => celsius + 273.15;
}
