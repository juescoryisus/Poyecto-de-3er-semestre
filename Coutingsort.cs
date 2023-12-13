using Poyecto_de_3er_semestre;
using System;

class Cou
{
    public static void couting()
    {
        int[] array = new int[0];

        do
        {
            Console.WriteLine("1. Agregar valor");
            Console.WriteLine("2. Ordenar con Counting Sort");
            Console.WriteLine("3. Mostrar array");
            Console.WriteLine("4. Regresar al Menu de Algoritmos");

            int opcion = ObtenerOpcion();

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese un valor: ");
                    int valor = int.Parse(Console.ReadLine());
                    array = AgregarValor(array, valor);
                    break;

                case 2:
                    CountingSort(array);
                    Console.WriteLine("Array ordenado con Counting Sort");
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

    static void CountingSort(int[] array)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("El array está vacío. No hay nada que ordenar.");
            return;
        }

        int max = array[0];
        int min = array[0];

        // Encontrar el valor máximo y mínimo en el array
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];

            if (array[i] < min)
                min = array[i];
        }

        int range = max - min + 1;
        int[] count = new int[range];
        int[] output = new int[array.Length];

        // Inicializar el array de conteo
        for (int i = 0; i < range; i++)
            count[i] = 0;

        // Contar la frecuencia de cada elemento
        for (int i = 0; i < array.Length; i++)
            count[array[i] - min]++;

        // Actualizar el array de conteo para almacenar la posición real de cada elemento
        for (int i = 1; i < range; i++)
            count[i] += count[i - 1];

        // Construir el array de salida
        for (int i = array.Length - 1; i >= 0; i--)
        {
            output[count[array[i] - min] - 1] = array[i];
            count[array[i] - min]--;
        }

        // Copiar el array ordenado de vuelta al array original
        Array.Copy(output, array, array.Length);
    }
}
