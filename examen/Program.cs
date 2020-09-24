// Examen de Desarrollo de Aplicaciones en Internet
// Nombre:    Edgar Baeza Tinajero
// Matricula: 33140751

using System;

namespace examen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creacion de red
            Console.WriteLine(">> Datos generales de la red\n");
            Red empresa = new Red("Red Patito, S.A. de C.V.", "Mr Pato McDonald", "Av. Princeton 123, Orlando Florida");
            
            // Agregando nodos
            empresa.nodos.Add(new Nodo("192.168.0.10", "servidor",  5, 10, "linux"));
            empresa.nodos.Add(new Nodo("192.168.0.12", "equipoactivo", 2, 12, "ios"));
            empresa.nodos.Add(new Nodo("192.168.0.20", "computadora", 8, 5, "windows"));
            empresa.nodos.Add(new Nodo("192.168.0.15", "servidor", 10, 22, "linux"));
            
            // Agregando vulnerabilidades
            empresa.nodos[0].vul.Add(new Vulnerabilidad("CVE-2015-1635", "Microsoft", "HTTP.sys permite a atacantes remotos ejecutar código arbitrario", "remota", new DateTime(2015,04,14)));
            empresa.nodos[0].vul.Add(new Vulnerabilidad("CVE-2017-0004", "Microsoft", "El servicio LSASS permite causar una denegación de servicio", "local", new DateTime(2017,01,10)));
            empresa.nodos[1].vul.Add(new Vulnerabilidad("CVE-2017-3847", "Cisco", "Cisco Firepower Management Center XSS", "remota", new DateTime(2017,02,21)));
            empresa.nodos[2].vul.Add(new Vulnerabilidad("CVE-2009-2504", "Microsoft", "Multiples desbordamientos de enteros en APIs Microsoft .NET1.1", "local", new DateTime(2009,11,13)));
            empresa.nodos[2].vul.Add(new Vulnerabilidad("CVE-2016-7271", "Microsoft", "Elevacion de privilegios Kernel Segura en Windos 10 Gold", "local", new DateTime(2016,12,20)));
            empresa.nodos[2].vul.Add(new Vulnerabilidad("CVE-2017-2996", "Adobe", "Adobe Flash Player 24.0.0.194 corrupcion de memoria explotable", "remota", new DateTime(2017,02,17)));

            // imprimiendo datos generales de la Red
            Console.WriteLine(">> Datos generales de la red:");
            Console.WriteLine(empresa.ToString());

            // Nodos totales y vulnerabilidades totales de la red
            Console.WriteLine($"\nTotal nodos red: { empresa.nodos.Count }");
            Console.WriteLine($"Total vulnerabilidades: { empresa.numVul() }");

            // Datos generales de los nodos
            Console.WriteLine("\n>> Datos generales de los nodos\n");
            empresa.nodos.ForEach( ndo => Console.WriteLine(ndo.ToString()));

            // Mayor y menor numero de saltos
            Console.WriteLine($"\nMayor numero de saltos: {empresa.maySal()}");
            Console.WriteLine($"Menor numero de saltos: {empresa.menSal()}");
           
            // Vulnerabilidades por nodo
            Console.WriteLine("\n>> Vulnerabilidades por nodo");
            foreach (Nodo n in empresa.nodos){
                // Se imprime la ip y el tipo de vulnerabilidad
                Console.WriteLine($"\n> Ip: {n.Ip}    Tipo: {n.Tipo}");
                Console.WriteLine("\nVulnerabilidades:\n");
                // Se imprime las vulnerabilidades del nodo
                n.vul.ForEach(v => Console.WriteLine( v.ToString() ));       
                if(n.nV() == 0) 
                    Console.WriteLine("No tiene vulnerabilidades...");
            }//foreach
        }//main
    }//clase
}
