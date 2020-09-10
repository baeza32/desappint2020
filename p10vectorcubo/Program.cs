﻿// Programa que genera un vector aleatorio, lo eleva el cubo y lo guarda en otro vector
// Edgar Baeza Tinajero
// * de Septiembre 2020

using System;

namespace p10vectorcubo
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] A = new double[20];
            double[] B = new double[20];
            Random rnd = new Random();

            for (int i = 0; i < A.Length; i++){
                A[i] = rnd.Next(-10,50);
                B[i] = Math.Pow(A[i],3);
            }

            Console.WriteLine("\nElementos del arreglo A"); imprime(A);
            Console.WriteLine("\nElementos del arreglo B"); imprime(B);

        }

        static void imprime(double[] v){
            for(int i = 0; i <v.Length; i++){
                Console.Write($"{v[i]} ");
            }
        }
    }
}
