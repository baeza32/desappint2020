using System;

namespace p15cuentabancariav1
{

    class Cliente{
        private string nombre;
        private CuentaBancaria cuenta;

        public Cliente(){}
        
        public Cliente(string nombre){
            this.nombre = nombre;
        }//constructor

        public string Nombre{
            get{return nombre;}
            set{nombre = value;}
        }//nombre

        public CuentaBancaria Cuenta{
            get{return cuenta;}
            set{cuenta = value;}
        }//nombre

    }//clase

}