using System;

namespace Empresa_constructora
{

    public class Obrero : Persona
    {
        protected int nroLegajo;
        protected double sueldo;
        protected string cargo;

        public Obrero(string _nombre, string _apellido, int _dni, int _nroLegajo, double _sueldo, string _cargo) : base(_nombre, _apellido, _dni)
        {
            nroLegajo = _nroLegajo;
            sueldo = _sueldo;
            cargo = _cargo;
        }
        public int NroLegajo
        {
            get { return nroLegajo; }
            private set { nroLegajo = value; }
        }
        public double Sueldo
        {
            get { return sueldo; }
            private set { sueldo = value; }
        }
        public string Cargo
        {
            get { return cargo; }
            private set { cargo = value; }
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Legajo: {nroLegajo}, Cargo: {cargo}, Sueldo: {sueldo:C}";
        }

    }
}