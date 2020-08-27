using System;

namespace p03areatriangulo
{
    class Program
    {
        // Este programa permite calcular el area de un triangulo
        // Edgar Baeza Tinajero
        static void Main(string[] args)
        {
            float labase, laaltura;
            float area;

            Console.Clear();
            Console.Write("Dame  la base"); labase = float.Parse( Console.ReadLine() );
            Console.Write("Dame  la altura"); laaltura = float.Parse( Console.ReadLine() );

            area = laaltura * labase / 2 ;

            Console.Write($"Un triangulo de base {labase} y altura {laaltura} tiene un area de {area}");

        }
    }
}
