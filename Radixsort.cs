using Poyecto_de_3er_semestre;
using System;
using System.Collections.Generic;

class Radixsort
{
    public static void Radix()
    {
        int[] array = new int[0];

        do
        {
            Console.WriteLine("1. Agregar valor");
            Console.WriteLine("2. Ordenar con Radix Sort");
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
                    RadixSort(array);
                    Console.WriteLine("Array ordenado con Radix Sort");
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

    static void RadixSort(int[] array)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("El array está vacío. No hay nada que ordenar.");
            return;
        }

        int maximo = EncontrarMaximo(array);

        // Realizar el sort para cada dígito
        for (int exp = 1; maximo / exp > 0; exp *= 10)
        {
            ContarSort(array, exp);
        }
    }

    static void ContarSort(int[] array, int exp)
    {
        int n = array.Length;
        int[] resultado = new int[n];
        int[] contador = new int[10];

        // Inicializar el contador
        for (int i = 0; i < 10; i++)
        {
            contador[i] = 0;
        }

        // Contar la ocurrencia de cada dígito en la posición actual
        for (int i = 0; i < n; i++)
        {
            contador[(array[i] / exp) % 10]++;
        }

        // Modificar el contador para contener la posición real de los dígitos en el resultado
        for (int i = 1; i < 10; i++)
        {
            contador[i] += contador[i - 1];
        }

        // Construir el array resultado
        for (int i = n - 1; i >= 0; i--)
        {
            resultado[contador[(array[i] / exp) % 10] - 1] = array[i];
            contador[(array[i] / exp) % 10]--;
        }

        // Copiar el array resultado de vuelta al array original
        Array.Copy(resultado, array, n);
    }

    static int EncontrarMaximo(int[] array)
    {
        int maximo = array[0];
        foreach (var valor in array)
        {
            if (valor > maximo)
            {
                maximo = valor;
            }
        }
        return maximo;
    }
}
