using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace randoms
{
    internal class Rnd
    {
        public static int[] rand1(int a) 
        {        // Enteros de 32 bits
            Random rnd = new Random();
            int[] arr = new int[a];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next();

            }
            return arr;
        }

        public static long[] rand2(int a)
        {        
            Random rnd = new Random();
            long[] arr = new long[a];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt64(rnd.Next());

            }
            return arr;
        }
        public static double[] rand3(int a)
        {        
            Random rnd = new Random();
            double[] arr = new double[a];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next();

            }
            return arr;
        }
        public static float[] rand4(int a)
        {        
            Random rnd = new Random();
            float[] arr = new float[a];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (float)rnd.Next();

            }
            return arr;
        }

        public static decimal[] rand5(int a)
        {        
            Random rnd = new Random();
            decimal[] arr = new decimal[a];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToDecimal(rnd.Next());

            }
            return arr;
        }
        public static string[] rand6(int a)
        {        
            Random rnd = new Random();
            string[] arr = new string[a];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(10000000,99999999).ToString();

            }
            return arr;
        }
        public static string[] rand7(int a)
        {        
            Random rnd = new Random();
            string[] arr = new string[a];

            for (int i = 0; i < arr.Length; i++)
            {
                double r = rnd.NextDouble() * (9.9999999 - 1.999999) + 1.999999;
                arr[i] = r.ToString();
            }
            return arr;
        }


    }

}