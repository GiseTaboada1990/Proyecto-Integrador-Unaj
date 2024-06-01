using System;

namespace Empresa_constructora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de Clase_persona
            Clase_persona persona = new Clase_persona();
            Clase_Obreros obrero = new Clase_Obreros();
            Jefe_de_Obra jefe = new Jefe_de_Obra();
            Clase_grupoObreros obra = new Clase_grupoObreros();

            // Mostrar la información de la persona
            //persona.DisplayInfo();
            jefe.CrearPersona("Juan","Perez",21787322);
            jefe.CrearObrero(36732873, 32763, "Jefe");
            obra.AgregarObrero(jefe);
            Console.WriteLine($"Nombre: {jefe.Nombre} {jefe.Apellido}, DNI: {jefe.Dni}, legajo: {jefe.NroLegajo}, sueldo: {jefe.Sueldo}, cargo: {jefe.Cargo}");
            obra.MostrarObreros();
        }
    }
}