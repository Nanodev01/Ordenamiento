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

                case '1': // Numeros Enteros <----

                    Menu();
                    opc = Console.ReadKey().KeyChar;
                    Console.Clear();
                    switch(opc)
                    {
                        case '1': // bubble sort

                            //int 32
                            Console.WriteLine("Ingrese la cantidad de datos que desea ordenar"); //pasar arriba del switch
                            int num = Convert.ToInt32(Console.ReadLine());
                            
                            DateTime inicio = DateTime.Now;
                            int[] arr = Rnd.rand1(num);
                            Or.Bubble(arr);
                            TimeSpan tiempo = DateTime.Now - inicio;
                            Console.WriteLine("El arreglo tiene {0} elementos", arr.Length);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[BubbleSort int32] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();

                            // agregar a los otros ejemplos
                            //int 64 ----- long
                            inicio = DateTime.Now;
                            long[] arrL = Rnd.rand2(num);
                            Or64.Bubble(arrL);
                            tiempo = DateTime.Now - inicio;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[BubbleSort long] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();                              
                           Console.ReadKey(); 
                        break;

                        case '2': //Merge sort (recursivo)

                            Console.WriteLine("Ingrese la cantidad de datos que desea ordenar"); //pasar arriba del switch
                            num = Convert.ToInt32(Console.ReadLine());
                            
                            inicio = DateTime.Now;
                            int[] arr1 = Rnd.rand1(num);
                            Or.MergeSort(ref arr1, 0, num - 1);
                            tiempo = DateTime.Now - inicio;
                            Console.WriteLine("El arreglo tiene {0} elementos", arr1.Length);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[MergeSort(recursivo) Int32] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();
                            //int 64 ----- long

                            inicio = DateTime.Now;
                            long[] arr1L = Rnd.rand2(num);
                            Or64.MergeSort(ref arr1L,0, num - 1);
                            tiempo = DateTime.Now - inicio;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[MergeSort(recursivo) long] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();
                            Console.ReadKey();
                        break;

                        case '3':// quick sort (recursivo)
                            Console.WriteLine("Ingrese la cantidad de datos que desea ordenar"); //pasar arriba del switch
                            num = Convert.ToInt32(Console.ReadLine());
                            
                            inicio= DateTime.Now;
                            int[] arr2 = Rnd.rand1(num);
                            Or.QuickSort(arr2, 0, num - 1);
                            tiempo = DateTime.Now - inicio;
                            Console.WriteLine("El arreglo tiene {0} elementos", arr2.Length);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[QuickSort(recursivo) int32] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();

                            //int 64 ----- long

                            inicio = DateTime.Now;
                            long[] arr2L = Rnd.rand2(num);
                            Or64.QuickSort(arr2L, 0, num - 1);
                            tiempo = DateTime.Now - inicio;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[QuickSort(recursivo) long] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();              
                            Console.ReadKey();

                        break;
                        
                        case '4':// quick sort (iterativo)
                            Console.WriteLine("Ingrese la cantidad de datos que desea ordenar"); //pasar arriba del switch
                            num = Convert.ToInt32(Console.ReadLine());
                            
                            inicio= DateTime.Now;
                            int[] arr3 = Rnd.rand1(num);
                            Or.QuickSortIterativo(arr3);
                            tiempo = DateTime.Now - inicio;
                            Console.WriteLine("El arreglo tiene {0} elementos", arr3.Length);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[QuickSort(iterativo) int32] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();                     
                            
                            //quick sort 64
                            inicio = DateTime.Now;
                            long[] arr3L = Rnd.rand2(num);
                            Or64.QuickSortIterativo(arr3L);
                            tiempo = DateTime.Now - inicio;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[QuickSort(iterativo) long] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();     

                            Console.ReadKey();
                        break;

                        case '5':// seleccion
                            Console.WriteLine("Ingrese la cantidad de datos que desea ordenar"); //pasar arriba del switch
                            num = Convert.ToInt32(Console.ReadLine());
                            
                            inicio= DateTime.Now;
                            int[] arr4 = Rnd.rand1(num);
                            Or.Seleccion(arr4);
                            tiempo = DateTime.Now - inicio;
                            Console.WriteLine("El arreglo tiene {0} elementos", arr4.Length);

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[seleccion int32] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();     
                                 

                            inicio = DateTime.Now;
                            long[] arr4L = Rnd.rand2(num);
                            Or64.Seleccion(arr4L);
                            tiempo = DateTime.Now - inicio;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[seleccion long] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();

                            Console.ReadKey();    

                        break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("[ERROR] El dato ingresado es invalido intente nuevamente");
                            Console.ResetColor();
                        break;
                    }
                break; 
                case '2': // Numeros Reales <--------

                    Menu();
                    opc = Console.ReadKey().KeyChar;
                    Console.Clear();
                    switch(opc)
                    {
                        case '1': // bubble sort

                            //reales 32 bits
                            Console.WriteLine("Ingrese la cantidad de datos que desea ordenar"); //pasar arriba del switch
                            int num = Convert.ToInt32(Console.ReadLine());
                            
                            DateTime inicio = DateTime.Now;
                            double[] arr = Rnd.rand3(num);
                            Dob.Bubble(arr);
                            TimeSpan tiempo = DateTime.Now - inicio;
                            Console.WriteLine("El arreglo tiene {0} elementos", arr.Length);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[BubbleSort double] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);
                            Console.ResetColor();
                            
                            Console.WriteLine("Desea continuar con los enteros de 64 bits?");
                            Console.WriteLine("1.- Si");
                            Console.WriteLine("2.- No");
                            int op = Convert.ToInt32(Console.ReadLine());
                            // agregar a los otros ejemplos                            
                            //reales de 128 ----- float
                            inicio = DateTime.Now;
                            float[] arrL = Rnd.rand4(num);
                            Dob128.Bubble(arrL);
                            tiempo = DateTime.Now - inicio;
                            Console.WriteLine("El arreglo tiene {0} elementos", arrL.Length);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[BubbleSort float] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();
                            


                            // se podria quitar;
                            Console.ReadKey(); 
                        break;

                        case '2': //Merge sort (recursivo)

                            Console.WriteLine("Ingrese la cantidad de datos que desea ordenar"); //pasar arriba del switch
                            num = Convert.ToInt32(Console.ReadLine());

                            inicio = DateTime.Now;
                            double[] arr1 = Rnd.rand3(num);
                            Dob.MergeSort(ref arr1, 0, num - 1);
                            tiempo = DateTime.Now - inicio;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[MergeSort(recursivo) doble] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();
                            //reales 128 ----- float

                            inicio = DateTime.Now;
                            float[] arr1L = Rnd.rand4(num);
                            Dob128.MergeSort(ref arr1L,0, num - 1);
                            tiempo = DateTime.Now - inicio;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[MergeSort(recursivo) float] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();
                            Console.ReadKey();
                        break;

                        case '3':// quick sort (recursivo)
                            Console.WriteLine("Ingrese la cantidad de datos que desea ordenar"); //pasar arriba del switch
                            num = Convert.ToInt32(Console.ReadLine());
                            
                            inicio= DateTime.Now;
                            double[] arr2 = Rnd.rand3(num);
                            Dob.QuickSort(arr2, 0, num - 1 );
                            tiempo = DateTime.Now - inicio;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[QuickSort(recursivo) double] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();
                            //reales 128 ----- float

                            inicio = DateTime.Now;
                            float[] arr2L = Rnd.rand4(num);
                            Dob128.QuickSort(arr2L, 0, num - 1);
                            tiempo = DateTime.Now - inicio;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[QuickSort(recursivo) float] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();
                            Console.ReadKey();

                        break;
                        
                        case '4':// quick sort (iterativo)
                            Console.WriteLine("Ingrese la cantidad de datos que desea ordenar"); //pasar arriba del switch
                            num = Convert.ToInt32(Console.ReadLine());
                            
                            inicio= DateTime.Now;
                            double[] arr3 = Rnd.rand3(num);
                            Dob.QuickSortIterativo(arr3);
                            tiempo = DateTime.Now - inicio;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[QuickSort(iterativo) double] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();
                            
                            
                            //quick sort 64
                            inicio = DateTime.Now;
                            float[] arr3L = Rnd.rand4(num);
                            Dob128.QuickSortIterativo(arr3L);
                            tiempo = DateTime.Now - inicio;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[QuickSort(iterativo) float] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();
                            Console.ReadKey();
                        break;

                        case '5':// seleccion
                            Console.WriteLine("Ingrese la cantidad de datos que desea ordenar"); //pasar arriba del switch
                            num = Convert.ToInt32(Console.ReadLine());
                            
                            inicio= DateTime.Now;
                            double[] arr4 = Rnd.rand3(num);
                            Dob.Seleccion(arr4);
                            tiempo = DateTime.Now - inicio;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[Seleccion doble] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();

                            inicio = DateTime.Now;
                            float[] arr4L = Rnd.rand4(num);
                            Dob128.Seleccion(arr4L);
                            tiempo = DateTime.Now - inicio;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[Seleccion float] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();
                            Console.ReadKey();
                            

                        break;

                        default:
                                Console.WriteLine("Error = Dato no valido");

                        break;
                    }

                break;                 
                case '3': // string

                    Menu();
                    opc = Console.ReadKey().KeyChar;
                    Console.Clear();
                    switch(opc)
                    {
                        case '1': // bubble sort

                            //int 32
                            Console.WriteLine("Ingrese la cantidad de datos que desea ordenar"); //pasar arriba del switch
                            int num = Convert.ToInt32(Console.ReadLine());
                            
                            DateTime inicio = DateTime.Now;
                            string[] arr = Rnd.rand6(num);
                            Str.Bubble(arr);
                            TimeSpan tiempo = DateTime.Now - inicio;
                            Console.WriteLine("El arreglo tiene {0} elementos", arr.Length);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[BubbleSort String 8 caracteres] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();

                            // agregar a los otros ejemplos
                            //int 64 ----- long
                            inicio = DateTime.Now;
                            string[] arrL = Rnd.rand7(num);
                            Str.Bubble(arrL);
                            tiempo = DateTime.Now - inicio;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[BubbleSort String 32 caracteres] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();                              
                           Console.ReadKey(); 
                        break;

                        case '2': //Merge sort (recursivo)

                            Console.WriteLine("Ingrese la cantidad de datos que desea ordenar"); //pasar arriba del switch
                            num = Convert.ToInt32(Console.ReadLine());
                            
                            inicio = DateTime.Now;
                            string[] arr1 = Rnd.rand6(num);
                            Str.MergeSort(arr1);
                            tiempo = DateTime.Now - inicio;
                            Console.WriteLine("El arreglo tiene {0} elementos", arr1.Length);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[MergeSort(recursivo) String 8 caracteres] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();
                            //int 64 ----- long

                            inicio = DateTime.Now;
                            string[] arr1L = Rnd.rand7(num);
                            Str.MergeSort(arr1L);
                            tiempo = DateTime.Now - inicio;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[MergeSort(recursivo) String 32 caracteres] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();
                            Console.ReadKey();
                        break;

                        case '3':// quick sort (recursivo)
                            Console.WriteLine("Ingrese la cantidad de datos que desea ordenar"); //pasar arriba del switch
                            num = Convert.ToInt32(Console.ReadLine());
                            
                            inicio= DateTime.Now;
                            string[] arr2 = Rnd.rand6(num);
                            Str.QuickSort(arr2, 0, num - 1);
                            tiempo = DateTime.Now - inicio;
                            Console.WriteLine("El arreglo tiene {0} elementos", arr2.Length);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[QuickSort(recursivo) String 8 caracteres] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();

                            //int 64 ----- long

                            inicio = DateTime.Now;
                            string[] arr2L = Rnd.rand7(num);
                            Str.QuickSort(arr2L, 0, num - 1);
                            tiempo = DateTime.Now - inicio;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[QuickSort(recursivo) String 32 caracteres] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();              
                            Console.ReadKey();

                        break;
                        
                        case '4':// quick sort (iterativo)
                            Console.WriteLine("Ingrese la cantidad de datos que desea ordenar"); //pasar arriba del switch
                            num = Convert.ToInt32(Console.ReadLine());
                            
                            inicio= DateTime.Now;
                            string[] arr3 = Rnd.rand6(num);
                            Str.QuickSortIterativo(arr3);
                            tiempo = DateTime.Now - inicio;
                            Console.WriteLine("El arreglo tiene {0} elementos", arr3.Length);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[QuickSort(iterativo) String 8 caracteres] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();                     
                            
                            //quick sort 64
                            inicio = DateTime.Now;
                            string[] arr3L = Rnd.rand7(num);
                            Str.QuickSortIterativo(arr3L);
                            tiempo = DateTime.Now - inicio;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[QuickSort(iterativo) String 32 caracteres] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();     

                        break;

                        case '5':// seleccion
                            Console.WriteLine("Ingrese la cantidad de datos que desea ordenar"); //pasar arriba del switch
                            num = Convert.ToInt32(Console.ReadLine());
                            
                            inicio= DateTime.Now;
                            string[] arr4 = Rnd.rand6(num);
                            Str.Seleccion(arr4);
                            tiempo = DateTime.Now - inicio;
                            Console.WriteLine("El arreglo tiene {0} elementos", arr4.Length);

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[seleccion String 8 caracteres] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();     
                                 

                            inicio = DateTime.Now;
                            string[] arr4L = Rnd.rand7(num);
                            Str.Seleccion(arr4L);
                            tiempo = DateTime.Now - inicio;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[seleccion String 32 caracteres] Tiempo elapsado: {0:D1}:{1:D2}:{2:D2},{3:d2}", tiempo.Hours, tiempo.Minutes, tiempo.Seconds, tiempo.Milliseconds);                                
                            Console.ResetColor();

                            Console.ReadKey();    

                        break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("[ERROR] El dato ingresado es invalido intente nuevamente");
                            Console.ResetColor();
                        break;
                    }

                break; 
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[ERROR] El dato ingresado es invalido intente nuevamente");
                    Console.ResetColor();
                break; 
            }
             
        }
    }
}
