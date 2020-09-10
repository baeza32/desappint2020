// Leer 2 vectores de tamanio n, y multiplicar el primer  elemento de A con el ultimo elemento de B
// Edgar Baeza Tinajero
// * de Septiembre 2020

using System;

namespace p13multiplicavector
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 3;
            double[] A = new double[MAX];
            double[] B = new double[MAX];
            double[] C = new double[MAX];

            Console.WriteLine("Dame los elentos de A"); leer(A);
            Console.WriteLine("Dame los elentos de B"); leer(B);

            for (int i = 0; i < MAX; i++){
                C[i] = A[i] * B[(MAX-1)-1];
            }

            Console.WriteLine("Los 3 vectores son");
            imprime(A);
            imprime(B);
            imprime(C);

        }
        
        static void leer(double[] v){
            for (int i = 0; i <v.Length; i++){
                Console.Write($"\nElemento[{i}]=");
                v[i] = double.Parse(Console.ReadLine());
            }
        }

        static void imprime(double[] v){
            for(int i = 0; i <v.Length; i++){
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine("");
        }
    }
}
