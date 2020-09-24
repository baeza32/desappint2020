using System;
using System.Collections.Generic;

namespace examen
{

    class Nodo{

        public string Ip { get; set; }
        public string Tipo { get; set; }
        public int Puertos { get; set; }
        public int Saltos { get; set; }
        public string Siop { get; set; }

        public Nodo(string ip, string tipo, int puertos, int saltos, string Siop){
            this.Ip = ip;
            this.Tipo = tipo;
            this.Puertos = puertos;
            this.Saltos = saltos;
            this.Siop = Siop;
        }//constructor
    
        public List<Vulnerabilidad> vul = new List<Vulnerabilidad>();

        public int nV(){
            return vul.Count;
        }

        public override string ToString() => 
            String.Format("Ip: {0,12}  Tipo: {1,-12}  Puertos: {2,-2}  Saltos: {3,-2}  SO: {4,-7}  TotVul: {5,1}", 
                           Ip, Tipo, Puertos, Saltos, Siop, vul.Count);

    }//clase

}