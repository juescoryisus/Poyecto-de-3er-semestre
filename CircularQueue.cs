using Poyecto_de_3er_semestre;
using System;

class CircularQueue
{
    public static void CIRCULAR()
    {
        CircularQueue<string> circularQueue = new CircularQueue<string>(5);

        while (true)
        {
            Console.WriteLine("1. Encolar");
            Console.WriteLine("2. Desencolar");
            Console.WriteLine("3. Mostrar elementos");
            Console.WriteLine("4. Regresar al Menu de Estructuras");

            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese el dato a encolar: ");
                    string datoEncolar = Console.ReadLine();
                    circularQueue.Enqueue(datoEncolar);
                    Console.WriteLine("Dato encolado: " + datoEncolar);
                    break;

                case "2":
                    if (!circularQueue.IsEmpty())
                    {
                        string datoDesencolar = circularQueue.Dequeue();
                        Console.WriteLine("Dato desencolado: " + datoDesencolar);
                    }
                    else
                    {
                        Console.WriteLine("La cola está vacía.");
                    }
                    break;

                case "3":
                    Console.WriteLine("Elementos en la cola:");
                    circularQueue.Display();
                    break;

                case "4":
                    Program.Main();
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

            Console.WriteLine(); // Separador para mejor legibilidad
        }
    }
}

class CircularQueue<T>
{
    private T[] array;
    private int size;
    private int front;
    private int rear;

    public CircularQueue(int capacity)
    {
        array = new T[capacity];
        size = 0;
        front = 0;
        rear = -1;
    }

    public void Enqueue(T item)
    {
        if (IsFull())
        {
            Console.WriteLine("La cola está llena. No se puede encolar.");
            return;
        }

        rear = (rear + 1) % array.Length;
        array[rear] = item;
        size++;
    }

    public T Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("La cola está vacía. No se puede desencolar.");
            return default(T);
        }

        T item = array[front];
        front = (front + 1) % array.Length;
        size--;
        return item;
    }

    public bool IsEmpty()
    {
        return size == 0;
    }

    public bool IsFull()
    {
        return size == array.Length;
    }

    public void Display()
    {
        if (size > 0)
        {
            Console.Write("Contenido de la Cola Circular: ");
            for (int i = 0; i < size; i++)
            {
                int index = (front + i) % array.Length;
                Console.Write($"{array[index]} ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("La cola está vacía.");
        }
    }
}
