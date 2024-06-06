using System;

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
        public static float[] rand3(int a)
        {        
            Random rnd = new Random();
            float[] arr = new float[a];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (float)rnd.Next();

            }
            return arr;
        }

        public static decimal[] rand4(int a)
        {        
            Random rnd = new Random();
            decimal[] arr = new decimal[a];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToDecimal(rnd.Next());

            }
            return arr;
        }


    }

}