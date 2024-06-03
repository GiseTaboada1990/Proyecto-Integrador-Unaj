using System;
using System.Security.Cryptography.X509Certificates;

namespace Empresa_constructora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de Clase_persona
            Clase_persona persona = new Clase_persona();
            Clase_Obreros obrero = new Clase_Obreros();
            Clase_Obreros obrero1 = new Clase_Obreros();
            Jefe_de_Obra jefe = new Jefe_de_Obra(); 
            Jefe_de_Obra jefe1 = new Jefe_de_Obra(); 
            Clase_grupoObreros grupo = new Clase_grupoObreros();
            EmpresaConstructora empresa = new EmpresaConstructora();
            Clase_obra obra = new Clase_obra();
            Clase_obra obra2 = new Clase_obra();
            // Mostrar la información de la persona
            //persona.DisplayInfo();

            jefe1.CrearPersona("Juan","Perez",21787322);
            jefe.CrearObrero(36732873, 32763, "Ingeniero");
            obrero.CrearPersona("Pedro","Pe",32893244);
            obrero.CrearObrero(36732873, 32763, "Peon");
            obrero1.CrearPersona("Pedro","Pe",32893244);
            obrero1.CrearObrero(36732873, 32763, "Peon");
            jefe.CrearPersona("Gonzalo","Taboada",37987302);
            jefe1.CrearObrero(2874833, 32763, "Ingeniero");
            jefe.AgregarObrero(obrero);
            jefe1.AgregarObrero(obrero1);
            grupo.AgregarObrero(jefe1);
            grupo.AgregarObrero(obrero);
            //Console.WriteLine($"Nombre: {jefe.Nombre} {jefe.Apellido}, DNI: {jefe.Dni}, legajo: {jefe.NroLegajo}, sueldo: {jefe.Sueldo}, cargo: {jefe.Cargo}");
            //grupo.MostrarObreros();
            obra.CrearObra(jefe,"Torre San Luis", false, 30000000,45, "Messi", 37849293, 3728);
            obra2.CrearObra(jefe1,"Torre San Juan", false, 30000000,45, "Messi", 37849293, 3728);
            empresa.AgregarObra(obra);
            empresa.AgregarObra(obra2);
            empresa.AgregarJefe(jefe1);
            empresa.AgregarJefe(jefe);
            empresa.ListaDeObras();
            empresa.InfoObras();
            empresa.ListaDeJefes();

        }
    }
}