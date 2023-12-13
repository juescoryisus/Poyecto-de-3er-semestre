using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto_de_3er_semestre
{
    internal class StackStatick
    {
        public void ver()
        {
            Console.WriteLine("Ingrese el tamaño de la Pila:");
            int tamano = int.Parse(Console.ReadLine());

            PilaE miPila = new PilaE(tamano);

            int opcion;
            do
            {
                Console.WriteLine("\n\n\n\t\tPila Estática");
                Console.WriteLine("  1. Insertar un dato");
                Console.WriteLine("  2. Sacar un dato");
                Console.WriteLine("  3. Visualizar Pila");
                Console.WriteLine("  4. Regresar al Menu de Estructuras");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el dato a insertar: ");
                        int datoInsertar = int.Parse(Console.ReadLine());
                        miPila.Insertar(datoInsertar);
                        break;

                    case 2:
                        int datoSacar = miPila.Sacar();
                        if (datoSacar != -1)
                        {
                            Console.WriteLine($"Dato sacado: {datoSacar}");
                        }
                        break;

                    case 3:
                        miPila.VerPila();
                        break;

                    case 4:
                        Program.Main();
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcion != 0);
        }

    }

}



class PilaE
{
    private int tam, tope;
    private int[] P;

    public PilaE(int n)
    {
        tope = 0;
        tam = n;
        P = new int[tam];
    }

    public void Insertar(int dato)
    {
        if (tope < tam)
        {
            P[tope++] = dato;
            Console.WriteLine("Dato insertado correctamente.");
        }
        else
        {
            Console.WriteLine("La Pila está llena. No se pueden agregar más elementos.");
        }
    }

    public int Sacar()
    {
        if (tope > 0)
        {
            return P[--tope];
        }
        else
        {
            Console.WriteLine("La Pila está vacía. No se pueden sacar más elementos.");
            return -1; // Valor indicando que la pila está vacía
        }
    }

    public bool EstaVaciaPila()
    {
        return tope == 0;
    }

    public bool EstaLlenaPila()
    {
        return tope == tam;
    }

    public void VerPila()
    {
        if (tope > 0)
        {
            Console.Write("Contenido de la Pila: ");
            for (int i = 0; i < tope; i++)
            {
                Console.Write($"{P[i]} ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("La Pila está vacía.");
        }
    }
}





