using System;
using System.Collections.Generic;
namespace p15cuentabancariav1
{

    class Banco{
        private string nombre;
        private string propietario;
        private List<Cliente> clientes;

        public Banco(string nombre, string propietario){
            this.nombre = nombre;
            this.propietario = propietario;
            clientes = new List<Cliente>();
        }//constructor

        public string Nombre{
            get{return nombre;}
            set{nombre = value;}
        }//nombre

        public string Propietario{
            get{return propietario;}
            set{propietario = value;}
        }//propietario

        public List<Cliente> Clientes{
            get{return clientes;}
        }//lista de clientes 

        public void AgregarCliente(Cliente cte){
            clientes.Add(cte);
        }//AgregarCliente

    }//clase

}