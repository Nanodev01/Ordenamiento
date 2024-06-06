using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ordenamiento
{
    internal class Or
    {
        public static void bubble(int[] arr)
        {
            // ordenamiento bubble sort
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int aux = arr[i];
                        arr[i] = arr[j];
                        arr[j] = aux;
                    }
                }
            }
        }

        public static void MergeSort(ref int[] arr, int izquierda, int derecha)
        {
            if (izquierda < derecha)
            { 
                int centro = (izquierda + derecha) / 2;
                MergeSort(ref arr, izquierda, centro );
                MergeSort(ref arr, centro + 1, derecha);
                Merge(ref arr, izquierda, centro, derecha);
            }
        
        }
        static void Merge(ref int[] arr, int izquierda, int centro, int derecha)
        {
            int i, j, k;
	        int n1 = centro - izquierda + 1;
	        int n2 = derecha - centro;
	        int[] L = new int[n1];
	        int[] R = new int[n2];

	        for (i = 0; i < n1; i++)
	        	L[i] = arr[izquierda + i];

	        for (j = 0; j < n2; j++)
	        	R[j] = arr[centro + 1 + j];

	        i = 0;
	        j = 0;
	        k = izquierda;

	        while (i < n1 && j < n2)
	        {
	        	if (L[i] <= R[j])
	        	{
	        		arr[k] = L[i];
	        		i++;
	        	}
	        	else
	        	{
		        	arr[k] = R[j];
	        		j++;
	        	}

	        	k++;
	        }

	        while (i < n1)
	        {
	        	arr[k] = L[i];
	        	i++;
	        	k++;
	        }

	        while (j < n2)
	        {
	        	arr[k] = R[j];
	        	j++;
	        	k++;
	        }
            
        }
        

    }
}
