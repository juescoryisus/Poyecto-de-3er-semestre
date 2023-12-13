using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto_de_3er_semestre
{
    internal class CirularDoublyLinkedList
    {
        //Lista circular doble --- Cabeza y cual es el fianal

        Nodo primero = new Nodo();
        Nodo ultimo = new Nodo();

        public CirularDoublyLinkedList()
        {
            primero = null;
            ultimo = null;
        }

        //Lista circular doble 
        //primero = null    ultimo = null 
        public void insertarNodo()
        {
            Nodo nuevo = new Nodo();
            Console.Write("Ingrese el dato del nuevo Nodo:");
            nuevo.Dato = int.Parse(Console.ReadLine());
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
                primero.Siguiente = primero;
                primero.Atras = ultimo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Atras = ultimo;
                nuevo.Siguiente = primero;
                ultimo = nuevo;
                primero.Atras = ultimo;
            }

            Console.WriteLine(" \n Nuevo nodo ingresado con exito:");
        }


        public void desplegarlistaPU()
        {
            Nodo actual = new Nodo();
            actual = primero;
            if (actual != null)
            {
                do
                {
                    Console.WriteLine(" " + actual.Dato);
                    actual = actual.Siguiente;
                } while (actual != primero);
            }
            else
            {
                Console.WriteLine("\n La lista se encuentra vacia\n");
            }
        }


        public void desplegarlistasUP()
        {
            Nodo actual = new Nodo();
            actual = ultimo;
            if (actual != null)
            {
                do
                {
                    Console.WriteLine(" " + actual.Dato);
                    actual = actual.Atras;
                } while (actual != ultimo);

            }
            else
            {
                Console.WriteLine("\n La lista se encuentra vacia\n");
            }
        }

    }
}

class Nod
{
    private int Dato;
    private Nod Siguiente;
    private Nod Atras;

    public int dato
    {
        get { return Dato; }
        set { Dato = value; }
    }

    public Nod siguiente
    {
        get { return Siguiente; }
        set { Siguiente = value; }
    }

    public Nod atras
    {
        get { return Atras; }
        set { Atras = value; }
    }
}
