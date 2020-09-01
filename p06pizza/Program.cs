// Programa que permite pedir una pizza en base a la eleccion del usuario
// Edgar Baeza Tinajero
// 1 de Sep 2020

using System;


namespace p06pizza
{
    class Program
    {
        static int Main(string[] args)
        {
            // Variables para recibir parametrod
            char tam, cub, don;
            string[] ings;

            // Variables para guardar la eleccion del usuario
            string tamano, ingredientes="", cubierta, donde;

            Console.Clear();
            if (args.Length==0){ 
                Menu();
                return 1;
            }

            // Elegir tamano
            tam = char.Parse(args[0].ToUpper());
            if(tam=='P') tamano="Pequeña"; 
            else if(tam=='M') tamano="Mediana";
            else tamano="Grande";
            // else Console.WriteLine("La opcion que elegiste no esta permitida");

            // Elegir ingredientes
            ings =args[1].Split("+"); //Separa los ingredientes en base al signo +
            foreach(string i in ings){
                switch(char.Parse(i.ToUpper())){
                    case 'E': ingredientes += "Extraqueso "; break;
                    case 'C': ingredientes += "Champiniones "; break;
                    case 'P': ingredientes += "Pinia "; break;
                }
            }

            // Tipo de cubierta
            cub = char.Parse(args[2].ToUpper());
            cubierta = cub=='D' ? "Delgada": "Gruesa";

            // Elegir donde comer
            don = char.Parse(args[3].ToUpper());
            donde = don=='A' ? "Aqui": "Para llevar";


            Console.WriteLine("\nLa pizza que pediste es la siguiente");
            Console.WriteLine($"tamano: {tamano}");
            Console.WriteLine($"Ingredienes: {ingredientes}");
            Console.WriteLine($"Cubierta: {cubierta}");
            Console.WriteLine($"Donde: {donde}");

            return 0;
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("Elije las opciones segun deseas tu pizza");
            Console.WriteLine("tamano (P)equeña, (M)ediana, (G)rande");
            Console.WriteLine("Ingredienes: (E)xtraqueso, (C)hampiniones, (P)inia, unidos po +");
            Console.WriteLine("Cubierta: (D)elgada, (G)ruesa");
            Console.WriteLine("Donde la comes: (A)qui, (L)levar");
        }

    }
}
