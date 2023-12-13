using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto_de_3er_semestre
{
    internal class Double_list
    {

        //12,45,67,89,12....Lista Doble // primero-ultimo // ultimo-primero
        private Nodo primero = new Nodo();
        private Nodo ultimo = new Nodo();


        public Double_list()
        {
            primero = null;
            ultimo = null;
        }

        //Lista doble 
        //12,45,67,89,12....Lista Doble // primero-ultimo // ultimo-primero

        public void insertarNodo()
        {
            Nodo nuevo = new Nodo();
            Console.Write("Ingrese el nuevo dato que contendra el Nodo:");
            nuevo.Dato = int.Parse(Console.ReadLine());
            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = null;
                primero.Atras = null;
                ultimo = primero;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                nuevo.Atras = ultimo;
                ultimo = nuevo;
            }
            Console.Write("\n Nuevo noodo ingresado con exito\n");
        }

        public void desplegarlista()
        {
            Nodo actual = new Nodo();
            actual = primero;
            while (actual != null)
            {
                Console.WriteLine(" " + actual.Dato);
                actual = actual.Siguiente;
            }
        }

        public void desplegarlistaa()
        {
            Nodo actual = new Nodo();
            actual = ultimo;
            while (actual != null)
            {
                Console.WriteLine(" " + actual.Dato);
                actual = actual.Atras;
            }
        }



    }

}

//==============================================================================================================0

class Nodo
{
    private int dato;
    private Nodo siguiente;
    private Nodo atras;

    public int Dato
    {
        get { return dato; }
        set { dato = value; }

    }
    public Nodo Siguiente
    {
        get { return siguiente; }
        set { siguiente = value; }
    }

    public Nodo Atras
    {
        get { return atras; }
        set { atras = value; }
    }
}


