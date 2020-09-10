using System;

namespace p15cuentabancariav1
{

    class CuentaDeCheques : CuentaBancaria{
        private double proteccionSobregiro;

        public CuentaDeCheques(double saldo, double proteccionSobregiro)
            : base(saldo){
                this.proteccionSobregiro = proteccionSobregiro;
            }//constructor

        public override bool Retira(double cantidad){
            bool resultado = true;
            double proteccionRequerida = cantidad - saldo;
            if(proteccionSobregiro < proteccionRequerida){
                return false;
            }else{
                saldo = 0.0;
                proteccionSobregiro -= proteccionRequerida;
            }
            return resultado;
        }//Retira

    }//clase

}