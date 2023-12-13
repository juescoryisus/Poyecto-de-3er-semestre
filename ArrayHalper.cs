using Poyecto_de_3er_semestre;
using System;

class ArrayHelper
{
    public static int[] AgregarValor(int[] array, int valor)
    {
        int[] newArray = new int[array.Length + 1];
        Array.Copy(array, newArray, array.Length);
        newArray[array.Length] = valor;
        return newArray;
    }

    public static void MostrarArray(int[] array)
    {
        Console.WriteLine("Contenido del array:");
        foreach (var valor in array)
        {
            Console.Write(valor + " ");
        }
        Console.WriteLine();
    }

    public static void OrdenarArray(int[] array, string algoritmo)
    {
        switch (algoritmo.ToLower())
        {
            case "bubblesort":
                BubbleSort(array);
                Console.WriteLine("Array ordenado con Bubble Sort");
                break;

            case "selectionsort":
                SelectionSort(array);
                Console.WriteLine("Array ordenado con Selection Sort");
                break;

            case "insertionsort":
                InsertionSort(array);
                Console.WriteLine("Array ordenado con Insertion Sort");
                break;

            // Puedes agregar más casos para otros algoritmos

            default:
                Console.WriteLine("Algoritmo no válido");
                break;
        }
    }

    private static void BubbleSort(int[] array)
    {
        // Implementación de Bubble Sort
    }

    private static void SelectionSort(int[] array)
    {
        // Implementación de Selection Sort
    }

    private static void InsertionSort(int[] array)
    {
        // Implementación de Insertion Sort
    }
}

class ArrayHalper
{
    public static void Array()
    {
        int[] array = new int[0];

        do
        {
            Console.WriteLine("1. Agregar valor");
            Console.WriteLine("2. Ordenar array");
            Console.WriteLine("3. Mostrar array");
            Console.WriteLine("4. Regresar a Algoritmos");

            int opcion = ObtenerOpcion();

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese un valor: ");
                    int valor = int.Parse(Console.ReadLine());
                    array = ArrayHelper.AgregarValor(array, valor);
                    break;

                case 2:
                    Console.Write("Ingrese el nombre del algoritmo de ordenamiento (bubblesort, selectionsort, insertionsort, etc.): ");
                    string algoritmo = Console.ReadLine();
                    ArrayHelper.OrdenarArray(array, algoritmo);
                    break;

                case 3:
                    ArrayHelper.MostrarArray(array);
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
}

