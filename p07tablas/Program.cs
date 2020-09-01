// Programa que imprime las tablas de multiplicar
// Edgar Baeza Tinajero
// 1 de Sep 2020

using System;

namespace p07tablas
{
    class Program
    {
        static int Main(string[] args)
        {
            int op, tab, ini, fin;
            if(args.Length==0){
                Menu();
                return 1;
            }
            
            op = int.Parse(args[0]);  // Opcion del menu
            tab = int.Parse(args[1]); // La tabla
            ini = int.Parse(args[2]); // Inicio
            fin = int.Parse(args[3]); // Fin

            switch(op){
                case 1:{
                    for(int i=ini; i<fin; i++){
                        Console.WriteLine($"{tab} x {i} = {tab*i}");
                    }
                }break;

                case 2:{
                    for (int t = 1; t < tab; t++){
                        for(int i=ini; i<=fin; i++){
                            Console.WriteLine($"{t} x {i} = {t*i}");
                        }
                        Console.WriteLine($"\n");
                    }
                }break;
            }

            return 0;
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("[1] Imprime la tabla que quieras hasta donde quieras (ej. 5 10)");
            Console.WriteLine("[1] Imprime la tabla hasta donde quieras (ej. 5 10)");
        }
    }
}
