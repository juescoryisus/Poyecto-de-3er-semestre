using Poyecto_de_3er_semestre;
using System;

class Node
{
    public int Data { get; set; }
    public Node Next { get; set; }

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class SimpleList
{
    private Node head;

    public SimpleList()
    {
        head = null;
    }

    public void AgregarElemento(int data)
    {
        Node nuevoNodo = new Node(data);
        if (head == null)
        {
            head = nuevoNodo;
        }
        else
        {
            Node temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = nuevoNodo;
        }
    }

    public void MostrarLista()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.Data + " ");
            temp = temp.Next;
        }
        Console.WriteLine();
    }
}

class Simple_list
{
    public static void List()
    {
        SimpleList lista = new SimpleList();

        do
        {
            Console.WriteLine("1. Agregar elemento");
            Console.WriteLine("2. Mostrar lista");
            Console.WriteLine("3. Regresar al Menu de Estructuras");

            int opcion = ObtenerOpcion();

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese un valor: ");
                    int valor = int.Parse(Console.ReadLine());
                    lista.AgregarElemento(valor);
                    break;

                case 2:
                    Console.WriteLine("Contenido de la lista:");
                    lista.MostrarLista();
                    break;

                case 3:
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
}
