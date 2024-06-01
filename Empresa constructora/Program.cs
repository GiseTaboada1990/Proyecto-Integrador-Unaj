using System;

namespace Empresa_constructora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de Clase_persona
            Clase_persona persona = new Clase_persona("Juan", "Perez", 12345678);
            Clase_Obreros obrero = new Clase_Obreros("Juan", "Perez", 35324504, 278273, 5679,"albañil");

            // Mostrar la información de la persona
            //persona.DisplayInfo();
            obrero.DisplayInfo();
            obrero.EstablecerSueldo(540);
            obrero.EstablecerCargo("Albañil");
            obrero.EstablecerNroLegajo(67362);
        }
    }
}