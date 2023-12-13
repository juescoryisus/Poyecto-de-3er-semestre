using estructura_de_datoss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto_de_3er_semestre
{
    internal class BinaryTree
    {
        public void arbol()
        {
            ArbolBinario arbol = new ArbolBinario();

            while (true)
            {
                Console.WriteLine("1. Agregar dato al árbol");
                Console.WriteLine("2. Imprimir enorden");
                Console.WriteLine("3. Regresar al Menu de Estructuras");

                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el dato a agregar al árbol: ");
                        int datoAgregar = Convert.ToInt32(Console.ReadLine());
                        arbol.Insertar(datoAgregar);
                        Console.WriteLine("Dato agregado al árbol: " + datoAgregar);
                        break;

                    case "2":
                        Console.WriteLine("Recorrido inorden del árbol:");
                        arbol.ImprimirInorden();
                        Console.WriteLine();
                        break;

                    case "3":
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
}

namespace estructura_de_datoss
{
    class NodoArbol
    {
        public int Valor { get; set; }
        public NodoArbol Izquierdo { get; set; }
        public NodoArbol Derecho { get; set; }

        public NodoArbol(int valor)
        {
            Valor = valor;
            Izquierdo = null;
            Derecho = null;
        }
    }

    class ArbolBinario
    {
        private NodoArbol raiz;

        public ArbolBinario()
        {
            raiz = null;
        }

        public void Insertar(int valor)
        {
            raiz = InsertarRec(raiz, valor);
        }

        private NodoArbol InsertarRec(NodoArbol raizActual, int valor)
        {
            if (raizActual == null)
            {
                return new NodoArbol(valor);
            }

            if (valor < raizActual.Valor)
            {
                raizActual.Izquierdo = InsertarRec(raizActual.Izquierdo, valor);
            }
            else if (valor > raizActual.Valor)
            {
                raizActual.Derecho = InsertarRec(raizActual.Derecho, valor);
            }

            return raizActual;
        }

        public void ImprimirInorden()
        {
            ImprimirInordenRec(raiz);
        }

        private void ImprimirInordenRec(NodoArbol raizActual)
        {
            if (raizActual != null)
            {
                ImprimirInordenRec(raizActual.Izquierdo);
                Console.Write(raizActual.Valor + " ");
                ImprimirInordenRec(raizActual.Derecho);
            }
        }
    }
}

