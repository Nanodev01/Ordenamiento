using ordenamiento;
using randoms;
using System;
using System.Collections;
using System.Reflection.Emit;
using System.Threading;

namespace MyApp
{
    internal class Program
    {
        static void Menu()
        {
            Console.WriteLine("Que metodo quiere utilizar");
            Console.WriteLine("1.- Bubble sort");
            Console.WriteLine("2.- MergeSort (recursivo)");
            Console.WriteLine("3.- QuickSort (recursivo)");
            Console.WriteLine("4.- QuickSort (Secuencial)");
            Console.WriteLine("5.- Seleccion");            

        }


        static void Main(string[] args)  // Comienazo programa <------------------------------------
        {

            Console.WriteLine("- Bienvenido - ");
            Console.WriteLine("Que tipo de datos quiere ordenar?");
            Console.WriteLine("1.-Enteros");
            Console.WriteLine("2.-Reales");
            Console.WriteLine("3.-Strings");
            char opc = Console.ReadKey().KeyChar;
            Console.Clear();


            switch(opc){

                case '1': 

                    Menu();
                    // Agregar swich (5 casos)
                    Console.WriteLine("Ingrese la cantidad de datos que desea ordenar"); //pasar arriba del switch
                    int num = Convert.ToInt32(Console.ReadLine());
                    
                    DateTime inicio = DateTime.Now;
                    int[] arr = Rnd.rand1(num);
                    Or.bubble(arr);
                    TimeSpan tiempo = DateTime.Now - inicio;
                    // Bucle para mostrar los datos del array
                    // for(int i = 0; i < arr.Length; i++)
                    // {
                    //     Console.WriteLine("{0}", arr[i]);

                    // }
                    Console.WriteLine("El arreglo tiene {0} elementos", arr.Length);
                    Console.WriteLine("Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);
                    Console.ReadKey();

                break; 
                case '2': 
                    DateTime inicio1 = DateTime.Now;
                    // int[] arr1 = Rnd.rand1(num1); Arreglar
                    Or.bubble(arr1);
                    TimeSpan tiempo1 = DateTime.Now - inicio1;
                    Console.WriteLine("El arreglo tiene {0} elementos", arr1.Length);
                    Console.WriteLine("Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo1.Hours, tiempo1.Minutes, tiempo1.Seconds, tiempo1.Milliseconds);
                    Console.ReadKey();
                break;                 
                case '3': 

                break; 
                default:
                break; 
            }
            
            // DateTime inicio = DateTime.Now;
            // int[] arr = Rnd.rand1(5000000);
            // Or.MergeSort(ref arr, 0, arr.Length - 1);
            // TimeSpan tiempo = DateTime.Now - inicio;
            // // for(int i = 0; i < arr.Length; i++)
            // // {
            // //     Console.WriteLine("{0}", arr[i]);

            // // }
            // Console.WriteLine("El arreglo tiene {0} elementos", arr.Length);
            // Console.WriteLine("Tiempo elapsado: {0:D1}:{1:D2}:{2:D2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds);
            // Console.ReadKey();
           
        }
    }
}
