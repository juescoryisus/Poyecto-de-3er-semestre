using Poyecto_de_3er_semestre;
using System;

class Heapsort
{
    public static void Heap()
    {
        int[] array = new int[0];

        do
        {
            Console.WriteLine("1. Agregar valor");
            Console.WriteLine("2. Ordenar con Heap Sort");
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
                    HeapSort(array);
                    Console.WriteLine("Array ordenado con Heap Sort");
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

    static void HeapSort(int[] array)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("El array está vacío. No hay nada que ordenar.");
            return;
        }

        // Construir un heap máximo
        for (int i = array.Length / 2 - 1; i >= 0; i--)
        {
            Heapify(array, array.Length, i);
        }

        // Extraer elementos uno por uno del heap
        for (int i = array.Length - 1; i > 0; i--)
        {
            // Mover la raíz (máximo elemento) al final del array
            Swap(ref array[0], ref array[i]);

            // Llamar a Heapify en el heap reducido
            Heapify(array, i, 0);
        }
    }

    static void Heapify(int[] array, int n, int i)
    {
        int max = i; // Inicializar el máximo como la raíz
        int izquierda = 2 * i + 1;
        int derecha = 2 * i + 2;

        // Si el hijo izquierdo es mayor que la raíz
        if (izquierda < n && array[izquierda] > array[max])
        {
            max = izquierda;
        }

        // Si el hijo derecho es mayor que el máximo hasta ahora
        if (derecha < n && array[derecha] > array[max])
        {
            max = derecha;
        }

        // Si el máximo no es la raíz
        if (max != i)
        {
            Swap(ref array[i], ref array[max]);

            // Recursivamente Heapify el subárbol afectado
            Heapify(array, n, max);
        }
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}
