using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto_de_3er_semestre
{
    internal class Program
    {
        public static void Main()
        {

            Console.WriteLine("==============Entro a la estructura de datos=================");
            Console.WriteLine("Elige una de las Estructuras");
            Console.WriteLine("1.Listas");
            Console.WriteLine("2.Pilas");
            Console.WriteLine("3.Colas");
            Console.WriteLine("4.Arboles");
            Console.WriteLine("5.Grafos");
            Console.WriteLine("6.Algoritmos");

            if (int.TryParse(Console.ReadLine(), out int valor))
            {
                switch (valor)
                {

                    case 1:
                        Console.WriteLine("Entraste a las listas");
                        Console.WriteLine("Ingrese una opción (1).Simple List | (2).Double Lits | (3).Circular List | (4).Circular Doubly Linked List");
                        string opcion = Console.ReadLine();

                        switch (opcion)
                        {
                            case "1":
                                Simple_list.List();
                                break;
                            case "2":
                                Double_list l = new Double_list();
                                l.insertarNodo();
                                l.insertarNodo();
                                l.insertarNodo();
                                l.insertarNodo();
                                l.insertarNodo();
                                Console.WriteLine("\n PRIMERO AL ULTIMO");
                                l.desplegarlista();

                                Console.WriteLine("\n ULTIMO AL PRIMERO");
                                l.desplegarlistaa();
                                Console.ReadLine();

                                int p = ObOpcion();

                                switch (p)
                                {
                                    case 1:

                                        Program.Main();
                                        break;
                                }
                                int ObOpcion()
                                {
                                    Console.Write("Ingrese el Numero (1) para Regresar al Menu de Estructuras");
                                    return int.Parse(Console.ReadLine());
                                }

                                break;

                            case "3":
                                Circular_list C = new Circular_list();
                                C.insertarNodo();
                                C.insertarNodo();
                                C.insertarNodo();
                                C.insertarNodo();
                                C.insertarNodo();
                                Console.WriteLine(" \n La lista ingresada");
                                C.desplegarlista();

                                int op = ObteneOpcion();

                                switch (op)
                                {
                                    case 1:

                                        Program.Main();
                                        break;
                                }
                                 int ObteneOpcion()
                                {
                                    Console.Write("Ingrese el Numero 1 para Regresar al Menu de Estructuras" );
                                    return int.Parse(Console.ReadLine());
                                }

                                break;
                            case "4":
                                CirularDoublyLinkedList CDLL = new CirularDoublyLinkedList();
                                CDLL.insertarNodo();
                                CDLL.insertarNodo();
                                CDLL.insertarNodo();
                                CDLL.insertarNodo();
                                CDLL.insertarNodo();
                                Console.WriteLine("Desplegar lista primero al ultimo");
                                CDLL.desplegarlistaPU();
                                Console.WriteLine("Desplegar lista ultimo al primerp");
                                CDLL.desplegarlistasUP();
                                Console.ReadLine();

                                int o = ObteneOpciones();

                                switch (o)
                                {
                                    case 1:

                                        Program.Main();
                                        break;
                                }
                                int ObteneOpciones()
                                {
                                    Console.Write("Ingrese el Numero (1) para Regresar al Menu de Estructuras");
                                    return int.Parse(Console.ReadLine());
                                }

                                break;

                            default:
                                Console.WriteLine("Opción no válida");
                                break;

                        }
                        break;

                    case 2:
                        Console.WriteLine("===============Entraste a las pilas=====================");
                        Console.WriteLine("Ingrese una opción | (1).StackStatick | (2).StackDinamic:");
                        string opc = Console.ReadLine();

                        switch (opc)
                        {
                            case "1":
                                Console.WriteLine("==================Entraste a la pila estatica");
                                StackStatick clase = new StackStatick();
                                clase.ver();
                                break;


                            case "2":

                                Console.WriteLine("================Entro a la pila dinamica=============");
                                StackDinamic s = new StackDinamic();

                                s.insertarNodo();
                                s.insertarNodo();
                                s.insertarNodo();
                                s.insertarNodo();
                                s.insertarNodo();

                                Console.WriteLine("\n La pila ingresada\n\n");
                                s.desplegarPila();
                                Console.ReadLine();

                                int p = ObOpcion();

                                switch (p)
                                {
                                    case 1:

                                        Program.Main();
                                        break;
                                }
                                int ObOpcion()
                                {
                                    Console.Write("Ingrese el Numero (1) para Regresar al Menu de Estructuras");
                                    return int.Parse(Console.ReadLine());
                                }

                                break;

                            default:
                                Console.WriteLine("Opción no válida");
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("===============Entraste a las colas=====================");
                        Console.WriteLine("Ingrese una opción (1).Cola | (2).PrioridadQueue | (3).CircularQueue");
                        string opciones = Console.ReadLine();

                        switch (opciones)
                        {
                            case "1":
                                Console.WriteLine("==================Cola======================");
                                Cola clase = new Cola();
                                clase.hola();

                                break;

                            case "2":
                                Console.WriteLine("==================PropiedadQueue======================");
                                PioridadQueue clasi = new PioridadQueue();
                                clasi.observar();
                                break;

                            case "3":
                                Console.WriteLine("==================CircularQueue======================");
                                CircularQueue.CIRCULAR();
                                break;

                            default:
                                Console.WriteLine("Opción no válida");
                                break;
                        }
                        break;

                    case 4:
                        Console.WriteLine("===============Entraste a los arboles=====================");
                        Console.WriteLine("==================Binary tree======================");
                        BinaryTree binario = new BinaryTree();
                        binario.arbol();

                        break;


                    case 5:
                        Console.WriteLine("===============Entraste a los grafos=====================");
                        Console.WriteLine("Ingrese una opción (1).Graph | (2).Unidirected Graph");
                        string opcionesGraph = Console.ReadLine();

                        switch (opcionesGraph)
                        {
                            case "1":
                                Console.WriteLine("==================Graph======================");
                                DirectedGraph claseGraph = new DirectedGraph();
                                claseGraph.Dirigido();

                                break;

                            case "2":
                                Console.WriteLine("==================UnidirectedGraph======================");
                                UnidirectedGraph grafo = new UnidirectedGraph();
                                grafo.Unidirected();
                                break;



                            default:
                                Console.WriteLine("Opción no válida");
                                break;
                        }
                        break;

                    case 6:

                        Algoritmos.Ordenamiento();

                        break;
                }



            }
            else
            {
                Console.WriteLine("Entrada no valida .Por favor ingresas un numero.");
            }
            Console.ReadKey();




        }
    }
}
