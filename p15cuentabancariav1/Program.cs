using System;

namespace p15cuentabancariav1
{
    class Program
    {
        static void Main(string[] args)
        {

            Banco miBanco = new Banco("El cochinito", "Edgar Baeza");

            miBanco.AgregarCliente(new Cliente("Daniel Avalos"));
            miBanco.AgregarCliente(new Cliente("Elias Barrios"));
            miBanco.AgregarCliente(new Cliente("Paola Perez"));
            miBanco.AgregarCliente(new Cliente("Rosa Gonzales"));

            miBanco.Clientes[0].Cuenta = new CuentaBancaria(100);
            miBanco.Clientes[1].Cuenta = new CuentaBancaria(200);
            miBanco.Clientes[2].Cuenta = new CuentaBancaria(300);
            miBanco.Clientes[3].Cuenta = new CuentaBancaria(400);

            miBanco.Clientes[2].Cuenta.Retira(50);
            miBanco.Clientes[0].Cuenta.Deposito(75);

            Console.WriteLine("Reporte General\n");
            Console.WriteLine($"Banco {miBanco.Nombre} propiendad de {miBanco.Propietario} \n");

            foreach (Cliente cte in miBanco.Clientes){
                Console.WriteLine($"El cliente de nombre: {cte.Nombre} tiene un saldo de: {cte.Cuenta.Saldo}\n");
            }


        }
    }
}
