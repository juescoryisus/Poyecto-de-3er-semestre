using Poyecto_de_3er_semestre;
using System;

class Cocktailsort
{
    public static void COCK()
    {
        bool exit = false;
        int[] array = null;

        do
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Cocktail Sort");
            Console.WriteLine("2. Otra opción");
            Console.WriteLine("3. Regresar al menu de Algoritmos");
            Console.Write("Selecciona una opción: ");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    array = GetIntArrayFromUser();
                    Console.WriteLine("\nOriginal array:");
                    PrintArray(array);
                    CocktailSort(array);
                    Console.WriteLine("\nCocktail Sorted array:");
                    PrintArray(array);
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

    static void CocktailSort(int[] array)
    {
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 0; i <= array.Length - 2; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Swap(ref array[i], ref array[i + 1]);
                    swapped = true;
                }
            }

            if (!swapped)
                break;

            swapped = false;

            for (int i = array.Length - 2; i >= 0; i--)
            {
                if (array[i] > array[i + 1])
                {
                    Swap(ref array[i], ref array[i + 1]);
                    swapped = true;
                }
            }
        } while (swapped);
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static int[] GetIntArrayFromUser()
    {
        Console.WriteLine("Enter the number of elements:");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        Console.WriteLine("Enter the elements (integer numbers):");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        return array;
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
