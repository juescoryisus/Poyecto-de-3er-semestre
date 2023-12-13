using Poyecto_de_3er_semestre;
using System;

class Quicksort
{
   public  static void Quick()
    {
        int[] array = new int[0];

        do
        {
            Console.WriteLine("1. Agregar valor");
            Console.WriteLine("2. Ordenar con QuickSort");
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
                    QuickSort(array, 0, array.Length - 1);
                    Console.WriteLine("Array ordenado con QuickSort");
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

    static void QuickSort(int[] array, int izquierda, int derecha)
    {
        if (izquierda < derecha)
        {
            int indiceParticion = Particionar(array, izquierda, derecha);

            // Ordenar recursivamente los elementos antes y después de la partición
            QuickSort(array, izquierda, indiceParticion - 1);
            QuickSort(array, indiceParticion + 1, derecha);
        }
    }

    static int Particionar(int[] array, int izquierda, int derecha)
    {
        int pivote = array[derecha];
        int i = izquierda - 1;

        for (int j = izquierda; j < derecha; j++)
        {
            if (array[j] <= pivote)
            {
                i++;
                Swap(ref array[i], ref array[j]);
            }
        }

        Swap(ref array[i + 1], ref array[derecha]);
        return i + 1;
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}
