using System;
using System.Collections;

namespace Empresa_constructora
{

    public class Jefe_de_Obra : Obrero
    {
        //Atributos
        private double bonificacion;
        private GrupoObrero grupo;

        //Constructor
        public Jefe_de_Obra(string _nombre, string _apellido, int _dni, int _nroLegajo, double _sueldo, string _cargo, double _bonificacion) : base(_nombre, _apellido, _dni, _nroLegajo, _sueldo, _cargo)
        {
            bonificacion = _bonificacion;
        }
        //Propiedades
        public double Bonificacion
        {
            get { return bonificacion; }
            set { bonificacion = value; }
        }
        public GrupoObrero Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }
        //Método para asignar grupo obrero al jefe
        public void AsignarGrupoObrero(GrupoObrero nuevo)
        {
            Grupo = nuevo;
        }

        //Método para eliminar el grupo obrero del jefe

        public void EliminarGrupoObrero()
        {
            Grupo = null;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Bonificación: {bonificacion:C}";
        }


    }
}