//  Ejemplos de delegado milticast (un delegado que invoca varios metodos)
using System;

namespace p26Delegados2
{
    public delegate void MiDelegado(string msj);
    class Program
    {
        static void Main(string[] args)
        {
            MiDelegado d1, d2, d3, d;

            d1 = Mensaje.Mensaje1;
            d2 = Mensaje.Mensaje2;
            d = d1 + d2;
            d("El peje");
            d3 = (string msj) => Console.WriteLine($"{msj} - paga todo que no pare la fiesta");
            d += d3;
            d("El borolas");
            d -= d2;
            d("Penia");
            d -= d1;
            d("Tello");
        }
    }
}
