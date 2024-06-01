using System;

namespace Empresa_constructora{

    public class Clase_Obreros : Clase_persona
    {
        public int nroLegajo; 
        public double sueldo; 
        public string cargo; 

        public int NroLegajo
        { 
            get{ return nroLegajo;} 
            private set{ nroLegajo = value;} 
        }
        public double Sueldo
        {
            get{ return sueldo;} 
            private set{ sueldo = value;}
        }
        public string Cargo
        {
            get{ return cargo;} 
            private set{ cargo = value;}
        }
        public void CrearObrero(int _nroLegajo, double _sueldo, string _cargo)
        {
            nroLegajo = _nroLegajo;
            sueldo = _sueldo;
            cargo = _cargo;
        }
       
    }
}