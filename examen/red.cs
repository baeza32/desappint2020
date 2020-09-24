using System;
using System.Collections.Generic;
using System.Linq;

namespace examen
{

    class Red{

        public string Empresa { get; set; }
        public string Propietario { get; set; }
        public string Domicio { get; set; }

        public List<Nodo> nodos = new List<Nodo>();


        public Red(string empresa, string propietario, string domicio){
            this.Empresa = empresa;
            this.Propietario = propietario;
            this.Domicio = domicio;
        }//constructor

        // Obteniendo numeto total de vulnerabilidades
        public int numVul(){
            int vln = 0;
            foreach (Nodo nds in nodos)
                vln += nds.vul.Count;
            return vln;
        }

        //Calculamos el numero mayor de saltos
        public int maySal(){
            var sM = (from nds in nodos
                     select nds.Saltos).ToList();
            return sM.Max();
        }

        // Calculamos el numero menor de saltos
        public int menSal(){
            var sM = (from nds in nodos
                     select nds.Saltos).ToList();
            return sM.Min();
        }

        public override string ToString() => 
            $"\nEmpresa      : {Empresa}, \nNombre       : {Propietario}, \nDomicilio    : {Domicio}";

    }//clase

}