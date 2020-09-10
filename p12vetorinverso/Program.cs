// Programa que genera numeros aleatorios y guardarlo en orden inverso
// Edgar Baeza Tinajero
// * de Septiembre 2020

using System;

namespace p12vetorinverso
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] A = new double[15];
            double[] B = new double[15];
            Random rnd = new Random();

            for (int i = 0; i < A.Length; i++){
                A[i] = rnd.Next(1, 100);
                B[(A.Length-1)-i] = A[i];
            }

            Console.WriteLine("\nElementos del arreglo A "); imprime(A);
            Console.WriteLine("\nElementos del arreglo B"); imprime(B);
            Console.WriteLine("\nElementos del arreglo A ordenados"); 
            Array.Sort(A);
            imprime(A);
        }

        static void imprime(double[] v){
            for(int i = 0; i <v.Length; i++){
                Console.Write($"{v[i]} ");
            }
        }
    }
}
