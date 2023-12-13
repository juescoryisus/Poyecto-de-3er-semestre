using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto_de_3er_semestre
{
    internal class Circular_list
    {

        private Nodo primero = new Nodo();
        private Nodo ultimo = new Nodo();

        public Circular_list()
        {
            primero = null;
            ultimo = null;
        }

        public void insertarNodo()
        {
            Nodo nuevo = new Nodo();
            Console.Write("Ingrese el valor del nuevo valor:");
            nuevo.Dato = int.Parse(Console.ReadLine());

            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = primero;
                ultimo = primero;

            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = primero;
                ultimo = nuevo;

            }
            Console.WriteLine("\n Nodo ingresado con exito\n\n");

        }

        public void desplegarlista()
        {
            Nodo actual = new Nodo();
            actual = primero;
            if (actual != null)
            {
                //recorrer la lista 
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
    }



    class Nod
    {
        private int Dato;
        private Nodo Siguiente;

        public int dato
        {
            get { return Dato; }
            set { Dato = value; }
        }

        public Nodo siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }



    }
}