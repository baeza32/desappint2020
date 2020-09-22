using System;
using System.Collections.Generic;
using System.Linq;

namespace p22Linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> estudiantes = new List<Estudiante>(){
                new Estudiante {Matricula=111, Nombre="Juan Perez", Domicilio="Zacatecas", Califs = new List<float>{97,92,81,60}},
                new Estudiante {Matricula=123, Nombre="Maria Lopez", Domicilio="Fresnillo", Califs = new List<float>{75,84,91,39}},
                new Estudiante {Matricula=234, Nombre="Rodrigo Mata", Domicilio="Fresnillo", Califs = new List<float>{85,75,95,55}},
                new Estudiante {Matricula=345, Nombre="Mauricio Hernandez", Domicilio="Zacatecas", Califs = new List<float>{99,99,99,99}}
            };

            // estudiantes.Add(new Estudiante(568, "Daniel Avalos", "Chihuahua", new List<float>{95,32,25,45}));

            // Imprmir
            Console.WriteLine($"\nTodos los estudiantes:{estudiantes.Count()}" );
            estudiantes.ForEach(est => Console.WriteLine(est.ToString()));

            // Filtrar los estudiantes de Zacatecas
            var estzac = (from est in estudiantes where est.Domicilio.Contains("Zacatecas") select est).ToList();
            Console.WriteLine($"\nEstudiantes de Zacatecas:{estzac.Count()}" );
            estzac.ForEach(est => Console.WriteLine(est.ToString()));

            // Filtrar estudiantes con promedio de 9 y mostrar ordenadospor nombre decendente
            var otros = (from est in estudiantes 
                        where est.Califs.Average()>=70
                        orderby est.Nombre descending 
                        select est).ToList();
            Console.WriteLine($"\nEstudiantes con promedio mayor a 8 y ordenados por nombre:{otros.Count()}");
            otros.ForEach(est => Console.WriteLine(est.ToString()));

            // Consulta con datos agrupados
            var gpoest = from est in estudiantes group est by est.Domicilio;
            foreach (var gpo in gpoest){
                Console.WriteLine($"\n{gpo.Key}");
                foreach (Estudiante est in gpo){
                    Console.WriteLine(est.ToString());
                }
            }//foreach

            // Estudiantes y promedio
            var proms = (from est in estudiantes
                        select $"nombre={est.Nombre} prom={est.Califs.Average()}").ToList();
            Console.WriteLine("\nLista de alumnos y sus promedios");
            proms.ForEach(p => Console.WriteLine(p));


        }//main

    }
}
