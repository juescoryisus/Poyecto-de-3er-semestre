using Poyecto_de_3er_semestre;
using System;

class Insertionsort
{
    public static void Inser()
    {
        int[] array = new int[0];

        do
        {
            Console.WriteLine("1. Agregar valor");
            Console.WriteLine("2. Ordenar con Insertion Sort");
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
                    InsertionSort(array);
                    Console.WriteLine("Array ordenado con Insertion Sort");
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

    static void InsertionSort(int[] array)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("El array está vacío. No hay nada que ordenar.");
            return;
        }

        for (int i = 1; i < array.Length; i++)
        {
            int clave = array[i];
            int j = i - 1;

            // Mover los elementos del array[0..i-1] que son mayores que la clave
            // a una posición por delante de su posición actual
            while (j >= 0 && array[j] > clave)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }
            array[j + 1] = clave;
        }
    }
}
