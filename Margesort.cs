using Poyecto_de_3er_semestre;
using System;

class Margesort
{
    public static void Marge()
    {
        int[] array = new int[0];

        do
        {
            Console.WriteLine("1. Agregar valor");
            Console.WriteLine("2. Ordenar con Merge Sort");
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
                    MergeSort(array);
                    Console.WriteLine("Array ordenado con Merge Sort");
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

    static void MergeSort(int[] array)
    {
        if (array.Length == 0)
        {
            Console.WriteLine("El array está vacío. No hay nada que ordenar.");
            return;
        }

        int[] aux = new int[array.Length];
        MergeSort(array, aux, 0, array.Length - 1);
    }

    static void MergeSort(int[] array, int[] aux, int izquierda, int derecha)
    {
        if (izquierda < derecha)
        {
            int medio = (izquierda + derecha) / 2;

            // Ordenar la primera mitad y la segunda mitad
            MergeSort(array, aux, izquierda, medio);
            MergeSort(array, aux, medio + 1, derecha);

            // Combinar las mitades ordenadas
            Merge(array, aux, izquierda, medio, derecha);
        }
    }

    static void Merge(int[] array, int[] aux, int izquierda, int medio, int derecha)
    {
        // Copiar los elementos a un array auxiliar
        for (int i = izquierda; i <= derecha; i++)
        {
            aux[i] = array[i];
        }

        int indiceIzquierda = izquierda;
        int indiceDerecha = medio + 1;
        int indiceActual = izquierda;

        // Fusionar las dos mitades ordenadas
        while (indiceIzquierda <= medio && indiceDerecha <= derecha)
        {
            if (aux[indiceIzquierda] <= aux[indiceDerecha])
            {
                array[indiceActual] = aux[indiceIzquierda];
                indiceIzquierda++;
            }
            else
            {
                array[indiceActual] = aux[indiceDerecha];
                indiceDerecha++;
            }
            indiceActual++;
        }

        // Copiar los elementos restantes de la mitad izquierda
        while (indiceIzquierda <= medio)
        {
            array[indiceActual] = aux[indiceIzquierda];
            indiceIzquierda++;
            indiceActual++;
        }
    }
}
