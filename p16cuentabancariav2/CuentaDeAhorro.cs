using System;

namespace p15cuentabancariav1
{

    class CuentaDeAhorro : CuentaBancaria{
        private double tasaDeInteres;

        public CuentaDeAhorro(double saldo, double tasaDeInteres)
            : base(saldo)// llamada explicita al constructor base
        {
            this.tasaDeInteres = tasaDeInteres;
        }//constructor

        public void CalcularInteres(){
            saldo += (saldo * tasaDeInteres);
        }//CalcularInteres

    }//Clase

}