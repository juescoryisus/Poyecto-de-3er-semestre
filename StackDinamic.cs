using estructura_de_datoss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto_de_3er_semestre
{
    internal class StackDinamic
    {
        private Nodos Primero = new Nodos();

        public StackDinamic()
        {
            Primero = null;

        }


        public void insertarNodo()
        {
            Nodos Nuevo = new Nodos();
            Console.Write("Ingrese el dato que contendra el nuevo Nodo:");
            Nuevo.Dato = int.Parse(Console.ReadLine());

            Nuevo.Siguiente = Primero;
            Primero = Nuevo;

            Console.WriteLine("\n Nodo ingresado\n\n");

        }


        public void desplegarPila()
        {
            Nodos Actual = new Nodos();
            Actual = Primero;

            if (Primero != null)
            {

                while (Actual != null)
                {
                    Console.WriteLine(" " + Actual.Dato);
                    Actual = Actual.Siguiente;
                }

            }
            else
            {
                Console.WriteLine("\n La pila se encuentra vacia \n\n");
            }
        }



    }
}

namespace estructura_de_datoss
{
    class Nodos
    {

        private int dato;
        private Nodos siguiente;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public Nodos Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }


        }
    }
}