﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ordenamiento
{
    public class Or
    {
        public static void Bubble(int[] arr)
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

        public static void MergeSort(ref int[] arr1, int izquierda, int derecha)
        {
            if (izquierda < derecha)
            { 
                int centro = izquierda + (derecha - izquierda) / 2;
                MergeSort(ref arr1, izquierda, centro );
                MergeSort(ref arr1, centro + 1, derecha);
                Merge(ref arr1, izquierda, centro, derecha);
            }
        
        }
        static void Merge(ref int[] arr1, int izquierda, int centro, int derecha)
        {
            int i, j, k;
	        int n1 = centro - izquierda + 1;
	        int n2 = derecha - centro;
	        int[] L = new int[n1];
	        int[] R = new int[n2];

	        for (i = 0; i < n1; i++)
	        	L[i] = arr1[izquierda + i];

	        for (j = 0; j < n2; j++)
	        	R[j] = arr1[centro + 1 + j];

	        i = 0;
	        j = 0;
	        k = izquierda;

	        while (i < n1 && j < n2)
	        {
	        	if (L[i] <= R[j])
	        	{
	        		arr1[k] = L[i];
	        		i++;
	        	}
	        	else
	        	{
		        	arr1[k] = R[j];
	        		j++;
	        	}

	        	k++;
	        }

	        while (i < n1)
	        {
	        	arr1[k] = L[i];
	        	i++;
	        	k++;
	        }

	        while (j < n2)
	        {
	        	arr1[k] = R[j];
	        	j++;
	        	k++;
	        }
            
        }

		// quick sort
		public static void QuickSort(int[] array, int low, int high)
		{
			if (low < high)
			{
				int pivot = array[high];
				int i = low - 1;

				for (int j = low; j < high; j++)
				{
					if (array[j] <= pivot)
					{
						i++;
						int temp = array[i];
						array[i] = array[j];
						array[j] = temp;
					}
				}

				int temp1 = array[i + 1];
				array[i + 1] = array[high];
				array[high] = temp1;

				int pivotIndex = i + 1;

				QuickSort(array, low, pivotIndex - 1);
				QuickSort(array, pivotIndex + 1, high);
			}
		}		
		//quick sort iterativo
		public static void QuickSortIterativo(int[] array)
		{
			int n = array.Length;
			int[] stack = new int[n];
			int top = -1;

			stack[++top] = 0;
			stack[++top] = n - 1;

			while (top >= 0)
			{
				int high = stack[top--];
				int low = stack[top--];

				int pivot = array[high];
				int i = low - 1;

				for (int j = low; j < high; j++)
				{
					if (array[j] <= pivot)
					{
						i++;
						int temp = array[i];
						array[i] = array[j];
						array[j] = temp;
					}
				}

				int temp1 = array[i + 1];
				array[i + 1] = array[high];
				array[high] = temp1;

				int pivotIndex = i + 1;

				if (pivotIndex - 1 > low)
				{
					stack[++top] = low;
					stack[++top] = pivotIndex - 1;
				}

				if (pivotIndex + 1 < high)
				{
					stack[++top] = pivotIndex + 1;
					stack[++top] = high;
				}
			}
		}
		//seleccion
		public static void Seleccion(int[] array)
		{
       		int n = array.Length;

        	for (int i = 0; i < n - 1; i++)
        	{
            	int aux = i;

            	for (int j = i + 1; j < n; j++)
            	{
                	if (array[j] < array[aux])
                	{
                    	aux = j;
                	}
            	}

            	if (aux != i)
            	{
                	int temp = array[i];
                	array[i] = array[aux];
                	array[aux] = temp;
            	}
        	}
    	}

    }
	public class Or64
	{

        public static void Bubble(long[] arr)
        {
            // ordenamiento bubble sort
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        long aux = arr[i];
                        arr[i] = arr[j];
                        arr[j] = aux;
                    }
                }
            }
        }

        public static void MergeSort(ref long[] arr1, int izquierda, int derecha)
        {
            if (izquierda < derecha)
            { 
                int centro = izquierda + (derecha - izquierda) / 2;
                MergeSort(ref arr1, izquierda, centro );
                MergeSort(ref arr1, centro + 1, derecha);
                Merge(ref arr1, izquierda, centro, derecha);
            }
        
        }
        static void Merge(ref long[] arr1, int izquierda, int centro, int derecha)
        {
            int i, j, k;
	        int n1 = centro - izquierda + 1;
	        int n2 = derecha - centro;
	        long[] L = new long[n1];
	        long[] R = new long[n2];

	        for (i = 0; i < n1; i++)
	        	L[i] = arr1[izquierda + i];

	        for (j = 0; j < n2; j++)
	        	R[j] = arr1[centro + 1 + j];

	        i = 0;
	        j = 0;
	        k = izquierda;

	        while (i < n1 && j < n2)
	        {
	        	if (L[i] <= R[j])
	        	{
	        		arr1[k] = L[i];
	        		i++;
	        	}
	        	else
	        	{
		        	arr1[k] = R[j];
	        		j++;
	        	}

	        	k++;
	        }

	        while (i < n1)
	        {
	        	arr1[k] = L[i];
	        	i++;
	        	k++;
	        }

	        while (j < n2)
	        {
	        	arr1[k] = R[j];
	        	j++;
	        	k++;
	        }
            
        }

		// quick sort
		public static void QuickSort(long[] array, int low, int high)
		{
			if (low < high)
			{
				long pivot = array[high];
				int i = low - 1;

				for (int j = low; j < high; j++)
				{
					if (array[j] <= pivot)
					{
						i++;
						long temp = array[i];
						array[i] = array[j];
						array[j] = temp;
					}
				}

				long temp1 = array[i + 1];
				array[i + 1] = array[high];
				array[high] = temp1;

				int pivotIndex = i + 1;

				QuickSort(array, low, pivotIndex - 1);
				QuickSort(array, pivotIndex + 1, high);
			}
		}		
		//quick sort iterativo
		public static void QuickSortIterativo(long[] array)
		{
			int n = array.Length;
			long[] stack = new long[n];
			int top = -1;

			stack[++top] = 0;
			stack[++top] = n - 1;

			while (top >= 0)
			{
				long high = stack[top--];
				long low = stack[top--];

				long pivot = array[high];
				long i = low - 1;

				for (long j = low; j < high; j++)
				{
					if (array[j] <= pivot)
					{
						i++;
						long temp = array[i];
						array[i] = array[j];
						array[j] = temp;
					}
				}

				long temp1 = array[i + 1];
				array[i + 1] = array[high];
				array[high] = temp1;

				long pivotIndex = i + 1;

				if (pivotIndex - 1 > low)
				{
					stack[++top] = low;
					stack[++top] = pivotIndex - 1;
				}

				if (pivotIndex + 1 < high)
				{
					stack[++top] = pivotIndex + 1;
					stack[++top] = high;
				}
			}
		}
		//seleccion
		public static void Seleccion(long[] array)
		{
       		int n = array.Length;

        	for (int i = 0; i < n - 1; i++)
        	{
            	int aux = i;

            	for (int j = i + 1; j < n; j++)
            	{
                	if (array[j] < array[aux])
                	{
                    	aux = j;
                	}
            	}

            	if (aux != i)
            	{
                	long temp = array[i];
                	array[i] = array[aux];
                	array[aux] = temp;
            	}
        	}
    	}



	}

	public class Dob
	{
        public static void Bubble(double[] arr)
        {
            // ordenamiento bubble sort
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        double aux = arr[i];
                        arr[i] = arr[j];
                        arr[j] = aux;
                    }
                }
            }
        }

        public static void MergeSort(ref double[] arr1, int izquierda, int derecha)
        {
            if (izquierda < derecha)
            { 
                int centro = izquierda + (derecha - izquierda) / 2;
                MergeSort(ref arr1, izquierda, centro );
                MergeSort(ref arr1, centro + 1, derecha);
                Merge(ref arr1, izquierda, centro, derecha);
            }
        
        }
        static void Merge(ref double[] arr1, int izquierda, int centro, int derecha)
        {
            int i, j, k;
	        int n1 = centro - izquierda + 1;
	        int n2 = derecha - centro;
	        double[] L = new double[n1];
	        double[] R = new double[n2];

	        for (i = 0; i < n1; i++)
	        	L[i] = arr1[izquierda + i];

	        for (j = 0; j < n2; j++)
	        	R[j] = arr1[centro + 1 + j];

	        i = 0;
	        j = 0;
	        k = izquierda;

	        while (i < n1 && j < n2)
	        {
	        	if (L[i] <= R[j])
	        	{
	        		arr1[k] = L[i];
	        		i++;
	        	}
	        	else
	        	{
		        	arr1[k] = R[j];
	        		j++;
	        	}

	        	k++;
	        }

	        while (i < n1)
	        {
	        	arr1[k] = L[i];
	        	i++;
	        	k++;
	        }

	        while (j < n2)
	        {
	        	arr1[k] = R[j];
	        	j++;
	        	k++;
	        }
            
        }

		// quick sort
		public static void QuickSort(double[] array, int low, int high)
		{
			if (low < high)
			{
				double pivot = array[high];
				int i = low - 1;

				for (int j = low; j < high; j++)
				{
					if (array[j] <= pivot)
					{
						i++;
						double temp = array[i];
						array[i] = array[j];
						array[j] = temp;
					}
				}

				double temp1 = array[i + 1];
				array[i + 1] = array[high];
				array[high] = temp1;

				int pivotIndex = i + 1;

				QuickSort(array, low, pivotIndex - 1);
				QuickSort(array, pivotIndex + 1, high);
			}
		}		
		//quick sort iterativo
		public static void QuickSortIterativo(double[] array)
		{
			int n = array.Length;
			int[] stack = new int[n];
			int top = -1;

			stack[++top] = 0;
			stack[++top] = n - 1;

			while (top >= 0)
			{
				int high = stack[top--]; 
				int low = stack[top--];

				double pivot = array[high];
				int i = low - 1;

				for (int j = low; j < high; j++)
				{
					if (array[j] <= pivot)
					{
						i++;
						double temp = array[i];
						array[i] = array[j];
						array[j] = temp;
					}
				}

				double temp1 = array[i + 1];
				array[i + 1] = array[high];
				array[high] = temp1;

				int pivotIndex = i + 1;

				if (pivotIndex - 1 > low)
				{
					stack[++top] = low;
					stack[++top] = pivotIndex - 1;
				}

				if (pivotIndex + 1 < high)
				{
					stack[++top] = pivotIndex + 1;
					stack[++top] = high;
				}
			}
		}
		//seleccion
		public static void Seleccion(double[] array)
		{
       		int n = array.Length;

        	for (int i = 0; i < n - 1; i++)
        	{
            	int aux = i;

            	for (int j = i + 1; j < n; j++)
            	{
                	if (array[j] < array[aux])
                	{
                    	aux = j;
                	}
            	}

            	if (aux != i)
            	{
                	double temp = array[i];
                	array[i] = array[aux];
                	array[aux] = temp;
            	}
        	}
    	}

	}
	public class Dob128
	{
        public static void Bubble(float[] arr)
        {
            // ordenamiento bubble sort
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        float aux = arr[i];
                        arr[i] = arr[j];
                        arr[j] = aux;
                    }
                }
            }
        }

        public static void MergeSort(ref float[] arr1, int izquierda, int derecha)
        {
            if (izquierda < derecha)
            { 
                int centro = izquierda + (derecha - izquierda) / 2;
                MergeSort(ref arr1, izquierda, centro );
                MergeSort(ref arr1, centro + 1, derecha);
                Merge(ref arr1, izquierda, centro, derecha);
            }
        
        }
        static void Merge(ref float[] arr1, int izquierda, int centro, int derecha)
        {
            int i, j, k;
	        int n1 = centro - izquierda + 1;
	        int n2 = derecha - centro;
	        float[] L = new float[n1];
	        float[] R = new float[n2];

	        for (i = 0; i < n1; i++)
	        	L[i] = arr1[izquierda + i];

	        for (j = 0; j < n2; j++)
	        	R[j] = arr1[centro + 1 + j];

	        i = 0;
	        j = 0;
	        k = izquierda;

	        while (i < n1 && j < n2)
	        {
	        	if (L[i] <= R[j])
	        	{
	        		arr1[k] = L[i];
	        		i++;
	        	}
	        	else
	        	{
		        	arr1[k] = R[j];
	        		j++;
	        	}

	        	k++;
	        }

	        while (i < n1)
	        {
	        	arr1[k] = L[i];
	        	i++;
	        	k++;
	        }

	        while (j < n2)
	        {
	        	arr1[k] = R[j];
	        	j++;
	        	k++;
	        }
            
        }

		// quick sort
		public static void QuickSort(float[] array, int low, int high)
		{
			if (low < high)
			{
				float pivot = array[high];
				int i = low - 1;

				for (int j = low; j < high; j++)
				{
					if (array[j] <= pivot)
					{
						i++;
						float temp = array[i];
						array[i] = array[j];
						array[j] = temp;
					}
				}

				float temp1 = array[i + 1];
				array[i + 1] = array[high];
				array[high] = temp1;

				int pivotIndex = i + 1;

				QuickSort(array, low, pivotIndex - 1);
				QuickSort(array, pivotIndex + 1, high);
			}
		}		
		//quick sort iterativo
		public static void QuickSortIterativo(float[] array)
		{
			int n = array.Length;
			int[] stack = new int[n];
			int top = -1;

			stack[++top] = 0;
			stack[++top] = n - 1;

			while (top >= 0)
			{
				int high = stack[top--]; 
				int low = stack[top--];

				float pivot = array[high];
				int i = low - 1;

				for (int j = low; j < high; j++)
				{
					if (array[j] <= pivot)
					{
						i++;
						float temp = array[i];
						array[i] = array[j];
						array[j] = temp;
					}
				}

				float temp1 = array[i + 1];
				array[i + 1] = array[high];
				array[high] = temp1;

				int pivotIndex = i + 1;

				if (pivotIndex - 1 > low)
				{
					stack[++top] = low;
					stack[++top] = pivotIndex - 1;
				}

				if (pivotIndex + 1 < high)
				{
					stack[++top] = pivotIndex + 1;
					stack[++top] = high;
				}
			}
		}
		//seleccion
		public static void Seleccion(float[] array)
		{
       		int n = array.Length;

        	for (int i = 0; i < n - 1; i++)
        	{
            	int aux = i;

            	for (int j = i + 1; j < n; j++)
            	{
                	if (array[j] < array[aux])
                	{
                    	aux = j;
                	}
            	}

            	if (aux != i)
            	{
                	float temp = array[i];
                	array[i] = array[aux];
                	array[aux] = temp;
            	}
        	}
    	}


	}
	public class Str
	{
		public static void Bubble(string[] arr)
		{
			// Ordenamiento bubble sort
			int n = arr.Length;
			for (int i = 0; i < n - 1; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					if (arr[j].CompareTo(arr[i]) < 0)
					{
						string aux = arr[i];
						arr[i] = arr[j];
						arr[j] = aux;
					}
				}
			}
		}

		public static void MergeSort(string[] arr)
		{
			MergeSort(arr, 0, arr.Length - 1);
		}

		static void MergeSort(string[] arr, int left, int right)
		{
			if (left < right)
			{
				int middle = (left + right) / 2;

				MergeSort(arr, left, middle);
				MergeSort(arr, middle + 1, right);

				Merge(arr, left, middle, right);
			}
		}

		static void Merge(string[] arr, int left, int middle, int right)
		{
			int n1 = middle - left + 1;
			int n2 = right - middle;

			string[] L = new string[n1];
			string[] R = new string[n2];

			for (int o = 0; o < n1; ++o)
			{
				L[o] = arr[left + o];
			}

			for (int z = 0; z < n2; ++z)
			{
				R[z] = arr[middle + 1 + z];
			}

			int i = 0, j = 0;
			int k = left;

			while (i < n1 && j < n2)
			{
				if (L[i].CompareTo(R[j]) <= 0)
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

		public static void QuickSort(string[] array, int low, int high)
		{
			if (low < high)
			{
				string pivot = array[high];
				int i = low - 1;

				for (int j = low; j < high; j++)
				{
					if (array[j].CompareTo(pivot) <= 0)
					{
						i++;
						string temp = array[i];
						array[i] = array[j];
						array[j] = temp;
					}
				}

				string temp1 = array[i + 1];
				array[i + 1] = array[high];
				array[high] = temp1;

				int pivotIndex = i + 1;

				QuickSort(array, low, pivotIndex - 1);
				QuickSort(array, pivotIndex + 1, high);
			}
		}	

		public static void QuickSortIterativo(string[] array)
		{
			int n = array.Length;
			int[] stack = new int[n];
			int top = -1;

			stack[++top] = 0;
			stack[++top] = n - 1;

			while (top >= 0)
			{
				int high = stack[top--]; 
				int low = stack[top--];

				string pivot = array[high];
				int i = low - 1;

				for (int j = low; j < high; j++)
				{
					if (array[j].CompareTo(pivot) <= 0)
					{
						i++;
						string temp = array[i];
						array[i] = array[j];
						array[j] = temp;
					}
				}

				string temp1 = array[i + 1];
				array[i + 1] = array[high];
				array[high] = temp1;

				int pivotIndex = i + 1;

				if (pivotIndex - 1 > low)
				{
					stack[++top] = low;
					stack[++top] = pivotIndex - 1;
				}

				if (pivotIndex + 1 < high)
				{
					stack[++top] = pivotIndex + 1;
					stack[++top] = high;
				}
			}
		}


		public static void Seleccion(string[] arr)
		{
			int n = arr.Length;

			for (int i = 0; i < n - 1; i++)
			{
				int minIndex = i;

				for (int j = i + 1; j < n; j++)
				{
					if (arr[j].CompareTo(arr[minIndex]) < 0)
					{
						minIndex = j;
					}
				}

				string temp = arr[i];
				arr[i] = arr[minIndex];
				arr[minIndex] = temp;
			}
		}
	}
}
 