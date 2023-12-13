using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto_de_3er_semestre
{
    internal class PioridadQueue
    {
        public void observar()
        {
            Queue cola = new Queue();

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
                        cola.Enqueue(datoEncolar);
                        Console.WriteLine("Dato encolado: " + datoEncolar);
                        break;

                    case "2":
                        if (cola.Count > 0)
                        {
                            object datoDesencolar = cola.Dequeue();
                            Console.WriteLine("Dato desencolado: " + datoDesencolar);
                        }
                        else
                        {
                            Console.WriteLine("La cola está vacía.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Elementos en la cola:");
                        foreach (var elemento in cola)
                        {
                            Console.WriteLine(elemento);
                        }
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
