using System;
using System.Threading;

namespace MyApp
{
    internal class Program
    {
        static void bubble(int[] arr)
        { 
            // ordenamiento bubble sort
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++) {
                for (int j = i + 1; j < n; j++) {
                    if (arr[j] < arr[i]) { 
                        int aux = arr[i];
                        arr[i] = arr[j];
                        arr[j] = aux;
                    }
                }            
            }
        }
        public static Int32[] randEntero(int size) {        // Enteros de 32 bits
            Random rnd = new Random();
            Int32[] arr = new Int32[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next();
            
            }
            return arr;
        }

        public static Int64[] randEntero2(int size)
        {        
            Random rnd = new Random();
            Int32[] arr = new Int32[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next();

            }
            return arr;
        }


        static void Main(string[] args)  // Comienazo programa <------------------------------------
        {

            DateTime inicio = DateTime.Now;
            Int32[] arr = randEntero(100000);
            bubble(arr);
            TimeSpan tiempo = DateTime.Now - inicio;

            Console.WriteLine("Tiempo elapsado: {0:D1}:{1:D2}:{2:D2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds);
            Console.ReadKey();
           
        }
    }
}
