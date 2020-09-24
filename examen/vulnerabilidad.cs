using System;

namespace examen
{
    class Vulnerabilidad{

        string Clave { get; set; }
        string Vendedor { get; set; }
        string Descripcion { get; set; }
        string Tipo { get; set; }
        DateTime fecha;
        DateTime fechaAct = DateTime.Now;
        
        public Vulnerabilidad(string clave, string vendedor, string descripcion, string tipo, DateTime fecha){
            this.Clave = clave;
            this.Vendedor = vendedor;
            this.Descripcion = descripcion;
            this.Tipo = tipo;
            this.fecha = fecha;
        }//constructor
        
        public override string ToString() => 
            String.Format("Clave: {0}  Vendedor: {1,-9}  Descripcion: {2,-64}  Tipo: {3,-6}  Fecha: {4:dd/MM/yyyy}  Antiguedad: {5,2}", 
            Clave, Vendedor, Descripcion, Tipo, fecha, (fechaAct.Year - fecha.Year));

    }//clase
}