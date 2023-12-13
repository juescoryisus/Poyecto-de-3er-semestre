using Poyecto_de_3er_semestre;
using System;
using System.Diagnostics;

class Binarytreesort
{
    class Nodo
    {
        public int Valor;
        public Nodo Izquierda;
        public Nodo Derecha;

        public Nodo(int valor)
        {
            Valor = valor;
            Izquierda = Derecha = null;
        }
    }

    static Nodo raiz = null;

    public static void BINARYTREESORT ()
    {
        do
        {
            Console.WriteLine("1. Agregar valor");
            Console.WriteLine("2. Ordenar con Binary Tree Sort");
            Console.WriteLine("3. Mostrar en orden");
            Console.WriteLine("4. Regresar al Menu de Estructuras");

            int opcion = ObtenerOpcion();

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese un valor: ");
                    int valor = int.Parse(Console.ReadLine());
                    raiz = AgregarValor(raiz, valor);
                    break;

                case 2:
                    Console.WriteLine("Ordenando con Binary Tree Sort");
                    BinaryTreeSort(ref raiz);
                    break;

                case 3:
                    Console.WriteLine("Mostrando en orden:");
                    MostrarEnOrden(raiz);
                    Console.WriteLine();
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

    static Nodo AgregarValor(Nodo nodo, int valor)
    {
        if (nodo == null)
            return new Nodo(valor);

        if (valor < nodo.Valor)
            nodo.Izquierda = AgregarValor(nodo.Izquierda, valor);
        else if (valor > nodo.Valor)
            nodo.Derecha = AgregarValor(nodo.Derecha, valor);

        return nodo;
    }

    static void BinaryTreeSort(ref Nodo nodo)
    {
        if (nodo == null)
            return;

        BinaryTreeSort(ref nodo.Izquierda);

        Console.Write(nodo.Valor + " ");

        BinaryTreeSort(ref nodo.Derecha);
    }

    static void MostrarEnOrden(Nodo nodo)
    {
        BinaryTreeSort(ref nodo);
    }
}
