using System;

namespace Empresa_constructora{

    public class Clase_persona
    {
        public string nombre, apellido;
        public int dni;

        public string Nombre{
            get{
                return nombre;
            }
            set{
                nombre = value;
            }
        }
        public string Apellido{
            get{
                return apellido;
            }
            set{
                apellido = value;
            }
        }
        public int Dni{
            get{
                return dni;
            }
            set{
                dni = value;
            }
        }
        public void CrearPersona(string _nombre, string _apellido, int _dni){
            nombre = _nombre;
            apellido = _apellido;
            dni = _dni;
        }
        
      
        public void UpdateNombre(string nuevoNombre)
        {
            nombre = nuevoNombre;
        }

        public void UpdateApellido(string nuevoApellido)
        {
            apellido = nuevoApellido;
        }

        public void UpdateDNI(int nuevoDNI)
        {
            dni = nuevoDNI;
        }
        
    }
}