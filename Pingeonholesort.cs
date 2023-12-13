using Poyecto_de_3er_semestre;
using System;

class Pingeonhole
{
    public static void Pinge()
    {
        int[] array = new int[0];

        do
        {
            Console.WriteLine("1. Agregar valor");
            Console.WriteLine("2. Ordenar con Pigeonhole Sort");
            Console.WriteLine("3. Mostrar array");
            Console.WriteLine("4. Regresar a Algoritmos");

            int opcion = ObtenerOpcion();

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese un valor: ");
                    int valor = int.Parse(Console.ReadLine());
                    array = AgregarValor(array, valor);
                    break;

                case 2:
                    PigeonholeSort(array);
                    Console.WriteLine("Array ordenado con Pigeonhole Sort");
                    break;

                case 3:
                    MostrarArray(array);
                    break;

                case 4:
                    Algoritmos.Ordenamiento();
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

        } while (true);
    }

    static int ObtenerOpcion()
    {
        Console.Write("Ingrese su opción: ");
        return int.Parse(Console.ReadLine());
    }

    static int[] AgregarValor(int[] array, int valor)
    {
        int[] newArray = new int[array.Length + 1];
        Array.Copy(array, newArray, array.Length);
        newArray[array.Length] = valor;
        return newArray;
    }

    static void MostrarArray(int[] array)
    {
        Console.WriteLine("Contenido del array:");
        foreach (var valor in array)
        {
            Console.Write(valor + " ");
        }
        Console.WriteLine();
    }

    static void PigeonholeSort(int[] array)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("El array está vacío. No hay nada que ordenar.");
            return;
        }

        int min = array[0];
        int max = array[0];

        // Encontrar el rango del array
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
                min = array[i];
            if (array[i] > max)
                max = array[i];
        }

        int rango = max - min + 1;
        int[] pigeonHoles = new int[rango];

        // Inicializar los agujeros del palomar con 0
        for (int i = 0; i < rango; i++)
        {
            pigeonHoles[i] = 0;
        }

        // Llenar el palomar
        for (int i = 0; i < array.Length; i++)
        {
            pigeonHoles[array[i] - min]++;
        }

        // Reconstruir el array ordenado
        int indice = 0;
        for (int i = 0; i < rango; i++)
        {
            while (pigeonHoles[i] > 0)
            {
                array[indice] = i + min;
                indice++;
                pigeonHoles[i]--;
            }
        }
    }
}
