using System;

namespace Empresa_constructora{

    public class Clase_persona
    {
        private string nombre, apellido;
        private int dni;
        public Clase_persona(string nombre, string apellido, int dni){
            this.nombre = nombre;
            this.apellido= apellido;
            this.dni = dni;
        }
        public string Nombre{
            get{ return nombre;}
        }
        public string Apellido {
            get{ return apellido;}
        }
        public int _DNI {
            get{ return dni;}
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Nombre: {Nombre} {Apellido}, DNI: {dni}");
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