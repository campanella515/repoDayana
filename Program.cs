using System;
//Ejercicio 4: Determinar la Próxima Montaña Visible
//Este ejercicio involucra un array de montañas, y 
//Carmen busca las montañas más altas que tiene al frente.
class Program
{
    static void Main()
    {
        int[] cordillera = GenerarCordillera(11, 1500, 3000);
        MostrarCordillera(cordillera);

        Console.Write("Montaña de comienzo (0-10): ");
        int inicio = int.Parse(Console.ReadLine());

        MostrarCumbresAAlcanzar(cordillera, inicio);
    }

    static int[] GenerarCordillera(int tamano, int alturaMin, int alturaMax)
    {
        Random rand = new Random();
        int[] cordillera = new int[tamano];
        for (int i = 0; i < tamano; i++)
        {
            cordillera[i] = rand.Next(alturaMin, alturaMax + 1);
        }
        return cordillera;
    }

    static void MostrarCordillera(int[] cordillera)
    {
        Console.WriteLine("Cordillera generada:");
        for (int i = 0; i < cordillera.Length; i++)
        {
            Console.Write($"{i}\t");
        }
        Console.WriteLine();
        for (int i = 0; i < cordillera.Length; i++)
        {
            Console.Write($"{cordillera[i]}m\t");
        }
        Console.WriteLine();
    }

    static void MostrarCumbresAAlcanzar(int[] cordillera, int inicio)
    {
        for (int i = inicio + 1; i < cordillera.Length; i++)
        {
            if (cordillera[i] > cordillera[inicio])
            {
                Console.WriteLine($"Carmen querrá llegar a la cumbre {i} con {cordillera[i]}m.");
                inicio = i;
            }
        }
    }
}
