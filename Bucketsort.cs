using Poyecto_de_3er_semestre;
using System;

class Bucketsort
{
    public static void BUCKET()
    {
        bool exit = false;

        do
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Bucket Sort");
            Console.WriteLine("2. Otra opción");
            Console.WriteLine("3. Regresar al menu de Algoritmos");
            Console.Write("Selecciona una opción: ");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    RunBucketSort();
                    break;
                case "2":
                    // Lógica para la otra opción
                    break;
                case "3":
                    Algoritmos.Ordenamiento();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;
            }

        } while (!exit);
    }

    static void RunBucketSort()
    {
        Console.WriteLine("Enter the number of elements:");
        int size = int.Parse(Console.ReadLine());

        float[] array = new float[size];

        Console.WriteLine("Enter the elements (floating-point numbers between 0 and 1):");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array[i] = float.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nOriginal array:");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\n\nBucket Sorted array:");
        BucketSort(array);

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();
    }

    static void BucketSort(float[] array)
    {
        // Implementación de Bucket Sort
        // (El código de la función BucketSort del ejemplo anterior)
    }
}
