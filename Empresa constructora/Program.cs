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
            Clase_grupoObreros grupo = new Clase_grupoObreros();
            EmpresaConstructora empresa = new EmpresaConstructora();
            Clase_obra obra = new Clase_obra();
            // Mostrar la información de la persona
            //persona.DisplayInfo();
            obrero.CrearPersona("Juan","Perez",21787322);
            jefe.CrearObrero(36732873, 32763, "Ingeniero");
            jefe.CrearPersona("Gonzalo","Taboada",37987302);
            obrero.CrearObrero(2874833, 32763, "Albañil");
            grupo.AgregarObrero(jefe);
            grupo.AgregarObrero(obrero);
            //Console.WriteLine($"Nombre: {jefe.Nombre} {jefe.Apellido}, DNI: {jefe.Dni}, legajo: {jefe.NroLegajo}, sueldo: {jefe.Sueldo}, cargo: {jefe.Cargo}");
            //grupo.MostrarObreros();
            obra.CrearObra("Torre San Juan", false, 30000000,45, "Messi", 37849293, 3728);
            empresa.ListaDeObras();
        }
    }
}