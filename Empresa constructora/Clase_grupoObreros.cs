
using System;
using System.Collections.Generic;

namespace Empresa_constructora
{
	public class Clase_grupoObreros
	{
		// atributos
		private List<Clase_Obreros> grupo;
		private int codigo_interno;
		public Clase_grupoObreros()
        {
            grupo = new List<Clase_Obreros>();
        }
		public int Codigo_interno
		{
			get{return codigo_interno;}
			set{ codigo_interno = value;}
		}
		public void AgregarObrero(Clase_Obreros obrero)
		{
			grupo.Add(obrero);
		}
		public void EliminarObrero(Clase_Obreros obrero)
		{
			grupo.Remove(obrero);
		}
		
		public void MostrarObreros()
        {
            foreach (var obrero in grupo)
            {
                Console.WriteLine($"{obrero.nombre} {obrero.apellido}, Cargo: {obrero.cargo}, Sueldo: {obrero.sueldo}");
            }
        }
		public void Mostrar()
		{
			Console.WriteLine($"grupo: {grupo}");
		}
	}
}
