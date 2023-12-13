using Poyecto_de_3er_semestre;
using System;

class Combsort
{
    public static void COMB()
    {
        int[] array = new int[0];

        do
        {
            Console.WriteLine("1. Agregar valor");
            Console.WriteLine("2. Ordenar con Combsort");
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
                    COMB(array);
                    Console.WriteLine("Array ordenado con Combsort");
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

    static void COMB(int[] array)
    {
        int gap = array.Length;
        bool swapped = true;

        while (gap > 1 || swapped)
        {
            if (gap > 1)
                gap = (int)(gap / 1.3);

            int i = 0;
            swapped = false;

            while (i + gap < array.Length)
            {
                if (array[i] > array[i + gap])
                {
                    Swap(ref array[i], ref array[i + gap]);
                    swapped = true;
                }

                i++;
            }
        }
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}
