using System;

namespace p26Delegados2
{
    class Mensaje{
        public static void Mensaje1(string msj) => Console.WriteLine($"{msj} - lleva el pastel");
        public static void Mensaje2(string msj) => Console.WriteLine($"{msj} - fue el culpable se cancela la fiesta");
    }
}