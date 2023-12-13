using estructura_de_datoss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto_de_3er_semestre
{
    internal class DirectedGraph
    {
        public void Dirigido()
        {
            GrafoDirigido grafo = new GrafoDirigido();

            while (true)
            {
                Console.WriteLine("1. Agregar nodo al grafo");
                Console.WriteLine("2. Agregar arista al grafo");
                Console.WriteLine("3. Imprimir grafo");
                Console.WriteLine("4. Salir");

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
                        Console.Write("Ingrese el valor del nodo de origen: ");
                        int valorOrigen = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Ingrese el valor del nodo de destino: ");
                        int valorDestino = Convert.ToInt32(Console.ReadLine());
                        grafo.AgregarArista(valorOrigen, valorDestino);
                        Console.WriteLine($"Arista agregada de {valorOrigen} a {valorDestino}.");
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

                Console.WriteLine(); // Separador para mejor legibilidad
            }
        }

    }
}
namespace estructura_de_datoss
{
    class NodoGraph
    {
        public int Valor { get; set; }

        public NodoGraph(int valor)
        {
            Valor = valor;
        }
    }

    class GrafoDirigido
    {
        private Dictionary<NodoGraph, List<NodoGraph>> adyacencias;

        public GrafoDirigido()
        {
            adyacencias = new Dictionary<NodoGraph, List<NodoGraph>>();
        }

        public void AgregarNodo(int valor)
        {
            NodoGraph nuevoNodo = new NodoGraph(valor);
            adyacencias[nuevoNodo] = new List<NodoGraph>();
        }

        public void AgregarArista(int valorOrigen, int valorDestino)
        {
            NodoGraph nodoOrigen = ObtenerNodo(valorOrigen);
            NodoGraph nodoDestino = ObtenerNodo(valorDestino);

            if (nodoOrigen != null && nodoDestino != null)
            {
                adyacencias[nodoOrigen].Add(nodoDestino);
            }
        }

        private NodoGraph ObtenerNodo(int valor)
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