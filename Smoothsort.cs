using Poyecto_de_3er_semestre;
using System;

public class SmoothSort
{
    private int[] array;
    private int size;

    public SmoothSort(int[] inputArray)
    {
        array = inputArray;
        size = inputArray.Length;
    }

    public void Sort()
    {
        for (int i = 0; i < size; i++)
        {
            SiftDown(i);
        }

        for (int i = size - 1; i > 0; i--)
        {
            Swap(0, i);
            SiftUp(0, i - 1);
        }
    }

    private void SiftDown(int i)
    {
        int leftChild;
        int rightChild;
        int j;

        while (2 * i + 1 < size)
        {
            leftChild = 2 * i + 1;
            rightChild = leftChild + 1;
            j = i;

            if (rightChild < size && array[rightChild] > array[j])
            {
                j = rightChild;
            }

            if (array[leftChild] > array[j])
            {
                j = leftChild;
            }

            if (i == j)
            {
                break;
            }

            Swap(i, j);
            i = j;
        }
    }

    private void SiftUp(int i, int last)
    {
        while (i < last)
        {
            int j = 2 * i + 1;

            if (j + 1 <= last && array[j] < array[j + 1])
            {
                j++;
            }

            if (j <= last && array[i] < array[j])
            {
                Swap(i, j);
                i = j;
            }
            else
            {
                break;
            }
        }
    }

    private void Swap(int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

class Smooth
{
    public static void Smoot()
    {
        bool exit = false;
        int[] array = null;

        do
        {
            Console.WriteLine("Menú:");
            Console.WriteLine("1. Smooth Sort");
            Console.WriteLine("2. Regresar a Algoritmos");
            Console.Write("Selecciona una opción: ");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    array = GetIntArrayFromUser();
                    Console.WriteLine("\nOriginal array:");
                    PrintArray(array);

                    SmoothSort smoothSort = new SmoothSort(array);
                    smoothSort.Sort();

                    Console.WriteLine("\nSmooth Sorted array:");
                    PrintArray(array);
                    break;
               
                case "2":
                    Algoritmos.Ordenamiento();

                    break;
                default:
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    break;
            }

        } while (!exit);
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
