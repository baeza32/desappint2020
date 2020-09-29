using System;

namespace p24Interfaz2
{

    public class Organizmo{

        public void Respiracion() => Console.WriteLine("Respiracion");
        public void Movimiento() => Console.WriteLine("Movimiento");
        public void Crecimiento() => Console.WriteLine("Crecimiento");
    }

    public interface IAnimales{
        void Mulricelular();
        void Seangrecaliente();
    }

    public interface ICanino : IAnimales{
        void Correr();
        void Cuatropatas();
    }

    public interface IPajaro : IAnimales{
        void Volar();
        void Dospatas();
    }

    public class Perro : Organizmo, ICanino{
        public void Mulricelular() => Console.WriteLine("Multicelular perro");
        public void Seangrecaliente() => Console.WriteLine("Sangrecaliente perro");
        public void Correr() => Console.WriteLine("Correr perro");
        public void Cuatropatas() => Console.WriteLine("Cuatropatas perro");
    }
    public class Perico : Organizmo, IPajaro{
        public void Mulricelular() => Console.WriteLine("Multicelular perico");
        public void Seangrecaliente() => Console.WriteLine("Sangrecaliente perico");
        public void Volar() => Console.WriteLine("Volar perico");
        public void Dospatas() => Console.WriteLine("Dospatas perico");
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nSegundo Ejemplo de Interfaces:");

            Perro miperro = new Perro();
            Console.WriteLine("\nCaracteristicas del perro");
            miperro.Respiracion();
            miperro.Movimiento();
            miperro.Crecimiento();
            miperro.Mulricelular();
            miperro.Seangrecaliente();
            miperro.Correr();
            miperro.Cuatropatas();

            Perico miperico = new Perico();
            Console.WriteLine("\nCaracteristicas del perico");
            miperico.Respiracion();
            miperico.Movimiento();
            miperico.Crecimiento();
            miperico.Mulricelular();
            miperico.Seangrecaliente();
            miperico.Volar();
            miperico.Dospatas();

        }
    }
}
