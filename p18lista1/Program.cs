using System;
using System.Collections.Generic;

namespace p18lista1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definir lista con algunos valores iniciales de
            List<string> mats = new List<string>(){
                "Calculo I",
                "Redaccion Avanzada",
                "Introduction a la Ingenieria"
            };

            // Agregar elementos a la lista
            mats.Add("Matematicas Discretas");
            mats.Add("Compiladores einterpretes");
            imprime(mats);

            // Agregar un rango de Materias
            string[] mopt = {
                "Seguridad en Redes y sistemas (op)",
                "Topicos selectos de Redes (op)",
                "Criptografia Avanzada (op)"
            };

            mats.AddRange(mopt);
            imprime(mats);

            // ordenar la lista
            mats.Sort();
            imprime(mats);

            // Invertir la lista
            mats.Reverse();
            imprime(mats);

            // Buscar un elemento en la lista, en base a una condicion
            Console.WriteLine("Materias que tengan la palabra Discretas");
            string mat = mats.Find(x => x.Contains("Discretas"));
            Console.WriteLine(mat);
            
            // Buscar todas las materias en la lista, que son optativas
            Console.WriteLine("\nMaterias optativas");
            var ms = mats.FindAll(x => x.Contains("(op)"));
            imprime(ms);

        }

        static void imprime(List<string> lista){
            // foreach (string m in lista){ Console.WriteLine(m); }
            lista.ForEach(m => Console.WriteLine(m));
            Console.WriteLine("\n");
        }

    }
}
