using Poyecto_de_3er_semestre;
using System;

class Bubblesort
{
    public static void BUBBLE()
    {
        int[] array = new int[0];

        do
        {
            Console.WriteLine("1. Agregar valor");
            Console.WriteLine("2. Ordenar con Bubble Sort");
            Console.WriteLine("3. Mostrar array");
            Console.WriteLine("4. Regresar al Menu de Estructuras");

            int opcion = ObtenerOpcion();

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese un valor: ");
                    int valor = int.Parse(Console.ReadLine());
                    array = AgregarValor(array, valor);
                    break;

                case 2:
                    BubbleSort(array);
                    Console.WriteLine("Array ordenado con Bubble Sort");
                    break;

                case 3:
                    MostrarArray(array);
                    break;

                case 4:
                    Program.Main();
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

    static void BubbleSort(int[] array)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("El array está vacío. No hay nada que ordenar.");
            return;
        }

        int n = array.Length;
        bool swapped;

        do
        {
            swapped = false;
            for (int i = 1; i < n; i++)
            {
                if (array[i - 1] > array[i])
                {
                    Swap(ref array[i - 1], ref array[i]);
                    swapped = true;
                }
            }
            n--;
        } while (swapped);
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}
