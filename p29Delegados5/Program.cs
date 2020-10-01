﻿// Ejemplo de delegado como parametro
using System;

namespace p29Delegados5
{
    public delegate void MiDelegado(string msj);
    class Program
    {
        static void Main(string[] args)
        {
            MiDelegado d1, d2, d3;
            d1 = ClaseA.MetodoA;
            d1("Tradicional A");
            Invocar(d1);

            d2 = ClaseB.MetodoB;
            d2("Tradicional B");
            Invocar(d2);

            d3 = (string msj) => Console.WriteLine($"Llamando metodo con expresion Lambada: {msj}");
            d3("Tradicional");
            Invocar(d3);
            
        }

        static void Invocar(MiDelegado del){
            del("Hola desde el invocador: ");
        }

    }

    public class ClaseA{
        public static void MetodoA(string msj) => Console.WriteLine($"Llamamos al Metodo de la ClaseA {msj}");
    }

    public class ClaseB{
        public static void MetodoB(string msj) => Console.WriteLine($"Llamos al Metodo de la ClaseB {msj}");
    }
}
