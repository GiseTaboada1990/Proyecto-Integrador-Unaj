using System;
using System.Collections.Generic;

namespace Empresa_constructora
{
	//atributos
	public class EmpresaConstructora{
		private List<Clase_obra>  obras;
		
		//Constructor
		public EmpresaConstructora(){
			obras = new List<Clase_obra>();
			
		}
		//Propiedades
		
		//Métodos para agregar
		public void AgregarObra(Clase_obra nuevo){
			obras.Add(nuevo);
		}
		
		//Métodos para eliminar
		public void EliminarObra(Clase_obra obra){
			obras.Remove(obra);
		}
		public int CantidadObras()
		{
			return obras.Count;
		}
		public void ListaDeObras()
		{
			foreach(var obra in obras)
			{
				Console.WriteLine($"obra: {obra.NombreObra}");
			}
		}
	}	
}