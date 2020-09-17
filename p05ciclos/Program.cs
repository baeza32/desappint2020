// Ejercicios con ciclos for, while y do , do .. while
// Edgar Baeza Tinajero
// 1 de Sep 2020

using System;

namespace p05ciclos
{
    class Program
    {
        static int Main(string[] args)
        {
            int op, c=0, suma=0;
            Console.Clear();
            // Verifica que se hayan pasado argumentos de linea  de comando
            if(args.Length==0){
                Menu();
                return 1;
            }

            // Tomo el primer argumento de la lineade comando
            op = int.Parse(args[0]);

            switch(op){
                // Numero del 1 al 100 con while
                case 1: {
                    c=1; suma=0;
                    while(c <= 100){
                        Console.Write($"{c} ");
                        suma+=c;
                        c++;
                    }
                    Console.WriteLine($"\n La suma es {suma}");
                }
                break;

                // Numeros del 100 al 1 con do .. while
                case 2: {
                    c=100; suma=0;
                    do{
                        Console.Write($"{c} ");
                        suma+=c;
                        c--;
                    }while(c >= 1);
                    Console.WriteLine($"\n La suma es {suma}");
                }
                break;

                // Numeros del 50 al 200 con for
                case 3:{
                    suma = 0;
                    for (int i = 50; i <= 200; i++){
                        Console.Write($"{i} ");
                        suma += i;
                    }
                    Console.WriteLine($"\n La suma es {suma}");
                }
                break;
                
                // Numeros del 2 al 100 los pares con for
                case 4:{
                    suma = 0;
                    for (int i = 2; i <= 100; i+=2){
                        Console.Write($"{i} ");
                        suma += i;
                    }
                        Console.WriteLine($"\n La suma es {suma}");
                }
                break;
                
                // Numeros del 99 al 1 impares con for
                case 5:{
                    suma = 0;
                    for (int i = 99; i >= 1; i-=2){
                        Console.Write($"{i} ");
                        suma += i;
                    }
                        Console.WriteLine($"\n La suma es {suma}");
                }
                break;

               // Numeros del 272 al 40 en decrementos de 4 con chiclio while 
                case 6:{
                    c=272; suma=0;
                    while(c >= 40 ){
                        Console.Write($"{c} ");
                        suma+=c;
                        c-=4;
                    }
                    Console.WriteLine($"\n La suma es {suma}");
                    break;
                }
                // break;
            }


            return 0;
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("==== Uso de ciclios en el Lenguaje C# ====");
            Console.WriteLine("[1] Numeros del 1 al 100 con ciclio while");
            Console.WriteLine("[2] Numeros del 100 al 1 con ciclio do .. while");
            Console.WriteLine("[3] Numeros del 50 al 200 con ciclio for");
            Console.WriteLine("[4] Numeros del 2 al 100 solo con los pares con ciclo for");
            Console.WriteLine("[5] Numeros del 99 al 1 solo con impares con ciclo for");
            Console.WriteLine("[6] Numeros del 272 al 40 en decrementos de 4 con chiclio while");
        }
    }
}
