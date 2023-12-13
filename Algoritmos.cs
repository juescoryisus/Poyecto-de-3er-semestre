using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poyecto_de_3er_semestre
{
    internal class Algoritmos
    {

        public static void Ordenamiento()
        {
            Console.WriteLine("===============Entraste a los Algoritmos de ordenamiento=====================");
            int Opbciones;
            Console.WriteLine("============Menu de los Algoritmos=============");
            Console.WriteLine(" (1) BinaryTreeSort");
            Console.WriteLine(" (2) BubbleSort");
            Console.WriteLine(" (3) BucketSort");
            Console.WriteLine(" (4) CocktailSort");
            Console.WriteLine(" (5) CombSort");
            Console.WriteLine(" (6) CountingSort");
            Console.WriteLine(" (7) GnomeSort");
            Console.WriteLine(" (8) Heapsort");
            Console.WriteLine(" (9) InsertionSort");
            Console.WriteLine(" (10) Pergesort");
            Console.WriteLine(" (11) PigeonholeSort");
            Console.WriteLine(" (12) Quicksort");
            Console.WriteLine(" (13) RadixSort");
            Console.WriteLine(" (14) SelectionSort");
            Console.WriteLine(" (15) ShellSort");
            Console.WriteLine(" (16) SmoothSort");
            Console.WriteLine("(17) Regresar");
            Console.WriteLine("Eligio La Opcion:");
            Opbciones = Convert.ToByte(Console.ReadLine());

            switch (Opbciones)
            {
                case 1:
                    {
                        Console.WriteLine("==================BinaryTreeSort======================");

                        Binarytreesort.BINARYTREESORT();
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("==================BubbleSort======================");

                        Bubblesort.BUBBLE();
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("==================BucketSort======================");
                        Bucketsort.BUCKET();


                    }
                    break;

                case 4:
                    {
                        Console.WriteLine("==================CocktailSort======================");

                        Cocktailsort.COCK();

                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("==================CombSort======================");

                        Combsort.COMB();
                    }

                    break;
                case 6:
                    {
                        Console.WriteLine("==================CoutingSort======================");

                        Cou.couting();

                    }
                    break;
                case 7:
                    {
                        Console.WriteLine("==================GnomeSort======================");
                        Gnomesort.Gnome();


                    }
                    break;
                case 8:
                    {
                        Console.WriteLine("==================HeapSort======================");

                        Heapsort.Heap();
                      

                    }
                    break;
                case 9:
                    {
                        Console.WriteLine("==================InsertionSort======================");

                        Insertionsort.Inser();
                       
                    }
                    break;
                case 10:
                    {
                        Console.WriteLine("==================MargeSort======================");


                        Margesort.Marge();

                    }
                    break;
                case 11:
                    {
                        Console.WriteLine("==================PingeonholeSort======================");

                        Pingeonhole.Pinge();
                        
                    }
                    break;
                case 12:
                    {
                        Console.WriteLine("==================QuickSort======================");

                        Quicksort.Quick();

                    }
                    break;
                case 13:
                    {
                        Console.WriteLine("==================RadixSort======================");

                        Radixsort.Radix();

                    }
                    break;
                case 14:
                    {
                        Console.WriteLine("==================SeletionSort======================");

                        Selectionsort.Selection();
                        
                    }
                    break;
                case 15:
                    {
                        Console.WriteLine("==================ArrayHalperSort======================");

                        ArrayHalper.Array();

                    }
                    break;
                case 16:
                    Console.WriteLine("==================ShellSort======================");

                    Shellsort.Shell();

                    break;
                case 17:
                    {
                        Console.WriteLine("==================SmoothSort======================");

                        Smooth.Smoot();
                    }
                    break;

                case 18:
                    Program.Main();

                    break;
            }

        }
        static void PrintArray(int[] array)
        {
            foreach (var num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }


        static void DisplayArray(int[] arr)
        {
            foreach (var num in arr)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
    }
}



