using System;

namespace p15cuentabancariav1
{

    class CuentaBancaria {
        protected double saldo;//para que pueda ser accedido por las clases que lo hereden

        public CuentaBancaria(double saldo){
            this.saldo = saldo;
        }//constructor

        public double Saldo{
            get{return saldo;}
        }//Saldo

        public void Deposito(double cantidad){
            saldo += cantidad;
        }//Deposito

        public virtual bool Retira(double cantidad){// permite sobrecargar este metodo
            if(saldo >= cantidad ){
                saldo -= cantidad;
                return true;
            }else return false;
        }//Retira

    }//clase

}