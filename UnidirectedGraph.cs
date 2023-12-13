using estructura_de_datoss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto_de_3er_semestre
{
    internal class UnidirectedGraph
    {
        public void Unidirected()
        {
            GrafoNoDirigido grafo = new GrafoNoDirigido();

            while (true)
            {
                Console.WriteLine("1. Agregar nodo al grafo");
                Console.WriteLine("2. Agregar arista al grafo");
                Console.WriteLine("3. Imprimir grafo");
                Console.WriteLine("4. Regresar al Menu de Estructuras");

                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Ingrese el valor del nuevo nodo: ");
                        int valorNodo = Convert.ToInt32(Console.ReadLine());
                        grafo.AgregarNodo(valorNodo);
                        Console.WriteLine($"Nodo {valorNodo} agregado al grafo.");
                        break;

                    case "2":
                        Console.Write("Ingrese el valor del primer nodo: ");
                        int valorNodo1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el valor del segundo nodo: ");
                        int valorNodo2 = Convert.ToInt32(Console.ReadLine());
                        grafo.AgregarArista(valorNodo1, valorNodo2);
                        Console.WriteLine($"Arista agregada entre {valorNodo1} y {valorNodo2}.");
                        break;

                    case "3":
                        Console.WriteLine("Grafo actual:");
                        grafo.ImprimirGrafo();
                        break;

                    case "4":
                        Program.Main();
                        break;

                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }

            Console.WriteLine(); // Separador para mejor legibilidad
        }

    }
}


namespace estructura_de_datoss
{
    class NodoUnidirected
    {
        public int Valor { get; set; }

        public NodoUnidirected(int valor)
        {
            Valor = valor;
        }
    }

    class GrafoNoDirigido
    {
        private Dictionary<NodoUnidirected, List<NodoUnidirected>> adyacencias;

        public GrafoNoDirigido()
        {
            adyacencias = new Dictionary<NodoUnidirected, List<NodoUnidirected>>();
        }

        public void AgregarNodo(int valor)
        {
            NodoUnidirected nuevoNodo = new NodoUnidirected(valor);
            adyacencias[nuevoNodo] = new List<NodoUnidirected>();
        }

        public void AgregarArista(int valorNodo1, int valorNodo2)
        {
            NodoUnidirected nodo1 = ObtenerNodo(valorNodo1);
            NodoUnidirected nodo2 = ObtenerNodo(valorNodo2);

            if (nodo1 != null && nodo2 != null)
            {
                adyacencias[nodo1].Add(nodo2);
                adyacencias[nodo2].Add(nodo1); // Para un grafo no dirigido, se agrega una arista en ambas direcciones
            }
        }

        private NodoUnidirected ObtenerNodo(int valor)
        {
            foreach (var nodo in adyacencias.Keys)
            {
                if (nodo.Valor == valor)
                {
                    return nodo;
                }
            }

            return null;
        }

        public void ImprimirGrafo()
        {
            foreach (var nodo in adyacencias.Keys)
            {
                Console.Write($"Nodo {nodo.Valor}: ");

                foreach (var vecino in adyacencias[nodo])
                {
                    Console.Write($"{vecino.Valor} ");
                }

                Console.WriteLine();
            }
        }
    }
}