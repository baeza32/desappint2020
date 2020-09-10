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

            miBanco.Clientes[0].AgregarCuenta(new CuentaDeAhorro(500, 0.10));
            miBanco.Clientes[0].AgregarCuenta(new CuentaDeCheques(1500, 300));
            miBanco.Clientes[1].AgregarCuenta(new CuentaDeCheques(3000, 200));
            miBanco.Clientes[2].AgregarCuenta(new CuentaDeAhorro(2500, 0.08));
            miBanco.Clientes[2].AgregarCuenta(new CuentaDeCheques(500, 30));
            miBanco.Clientes[3].AgregarCuenta(new CuentaDeAhorro(1500, 0.9));
            miBanco.Clientes[3].AgregarCuenta(miBanco.Clientes[2].Cuentas[1]);

            miBanco.CalcularInteres();

            Console.WriteLine("Reporte Bancario");
            Console.WriteLine($"{miBanco.Nombre}  ---  {miBanco.Propietario}\n");
            Console.WriteLine($"Total de Clientes {miBanco.Clientes.Count}\n");
            foreach (Cliente cte in miBanco.Clientes){
                Console.WriteLine($"Cliente {cte.Nombre} tiene {cte.Cuentas.Count} cuentas que son: \n");
                foreach(CuentaBancaria cta in cte.Cuentas){
                    Console.Write((cta is CuentaDeAhorro)?"Cuenta de Ahorro: ":"Cueta de Cheques: ");
                    Console.WriteLine($"{cta.Saldo}");
                }
                Console.WriteLine();
            }
        }
    }
}
