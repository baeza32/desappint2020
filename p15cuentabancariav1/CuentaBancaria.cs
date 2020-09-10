using System;

namespace p15cuentabancariav1
{

    class CuentaBancaria {
        private double saldo;

        public CuentaBancaria(double saldo){
            this.saldo = saldo;
        }//constructor

        public double Saldo{
            get{return saldo;}
        }//Saldo

        public void Deposito(double cantidad){
            saldo += cantidad;
        }//Deposito

        public bool Retira(double cantidad){
            if(saldo >= cantidad ){
                saldo -= cantidad;
                return true;
            }else return false;
        }//Retira

    }//clase

}