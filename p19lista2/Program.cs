using System;
using System.Collections.Generic;

namespace p19lista2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista con elementos de tipo Pieza 
            List<Pieza> mp = new List<Pieza>();
            
            // Agregar piezas a la lista
            mp.Add(new Pieza(1234, "Tuerca de rosca interiro"));
            mp.Add(new Pieza(2345, "Tornillo de cabeza grande"));
            mp.Add(new Pieza(3456, "Clavos para concreto"));
            
            // Agregar rango de piezas
            var proveedor =new List<Pieza>(){
                new Pieza(4567, "Taquetes para madera"),
                new Pieza(5678, "Tornillos para madera"),
                new Pieza(6789, "Clavos para madera"),
            };
            mp.AddRange(proveedor);
            
            // Usar el metodo foreach integrado en la lista para imprimir su contenido
            mp.ForEach(p=>Console.WriteLine(p.ToString()));

            // Elimina el ultimo elemento de la lista
            Console.WriteLine("\nEliminar el ultimo elemento");
            mp.RemoveAt(mp.Count-1);
            mp.ForEach(p=>Console.WriteLine(p.ToString()));

            // Insertar un elemento en la segunda poscion
            Console.WriteLine("\nInsertar un elemento el la segunda poscion");
            mp.Insert(1, new Pieza(2222, "Caja de 8 velocidades"));
            mp.ForEach(p=>Console.WriteLine(p.ToString()));

            // Buscar todas las ocurrencias de la palabra tornillo
            Console.WriteLine("\nImprime las las piezas que contienen la palabra tornillo"); 
            var pzas = mp.FindAll(p => p.Nombre.Contains("Tornillo"));
            pzas.ForEach(p => Console.WriteLine(p.ToString()));

            // Busca las piezas con Id menor a 5000
            Console.WriteLine("\nImprime las las piezas con id menor a 5000"); 
            var pzas2 = mp.FindAll(p => p.Id < 5000 );
            pzas2.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
