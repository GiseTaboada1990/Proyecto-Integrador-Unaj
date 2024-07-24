using System;

namespace Empresa_constructora
{

    public class Persona
    {
        protected string nombre, apellido;
        protected int dni;


        public Persona(string _nombre, string _apellido, int _dni)
        {
            nombre = _nombre;
            apellido = _apellido;
            dni = _dni;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
        }
        public string Apellido
        {
            get
            {
                return apellido;
            }
        }
        public int Dni
        {
            get
            {
                return dni;
            }
        }
        public override string ToString()
        {
            return $"{nombre} {apellido}, DNI: {dni}";
        }
    }
}