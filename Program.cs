using ordenamiento;
using randoms;
using System;
using System.Threading;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)  // Comienazo programa <------------------------------------
        {
            
            DateTime inicio = DateTime.Now;
            int[] arr = Rnd.rand1(5000000);
            Or.MergeSort(ref arr, 0, arr.Length - 1);
            TimeSpan tiempo = DateTime.Now - inicio;
            // for(int i = 0; i < arr.Length; i++)
            // {
            //     Console.WriteLine("{0}", arr[i]);

            // }
            Console.WriteLine("El arreglo tiene {0} elementos", arr.Length);
            Console.WriteLine("Tiempo elapsado: {0:D1}:{1:D2}:{2:D2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds);
            Console.ReadKey();
           
        }
    }
}
