using System;

namespace Empresa_constructora{

    public class Clase_Obreros : Clase_persona
    {
        public int nroLegajo { get; private set; }
        public double sueldo { get; private set; }
        public string cargo { get; private set; }
        public Clase_Obreros(string nombre, string apellido, int dni,int nroLegajo, double sueldo, string cargo) : base(nombre, apellido, dni)
        {
            this.nroLegajo = nroLegajo;
            this.sueldo = sueldo;
            this.cargo = cargo;
        } 
        public void EstablecerSueldo(double nuevoSueldo)
        {
            sueldo = nuevoSueldo;
            Console.WriteLine($"Sueldo: {sueldo}");
        }
        public void EstablecerCargo(string nuevoCargo){
            cargo = nuevoCargo;
            Console.WriteLine($"Cargo: {cargo}");
        }
        public void EstablecerNroLegajo(int nuevoLegajo){
            nroLegajo = nuevoLegajo;
            Console.WriteLine($"Legajo: {nroLegajo}");
        }
    }
}