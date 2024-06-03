using System;
using System.Collections.Generic;

namespace Empresa_constructora
{
	//atributos
	public class EmpresaConstructora{
		public List<Clase_obra>  obras;
		public List<Jefe_de_Obra> jefes;
		
		//Constructor
		public EmpresaConstructora(){
			obras = new List<Clase_obra>();
			jefes = new List<Jefe_de_Obra>();
			
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
		public void AgregarJefe(Jefe_de_Obra jefe)
		{
			jefes.Add(jefe);
		}
		public int CantidadObras()
		{
			Console.WriteLine($"Cantidad: {obras.Count}");
			return obras.Count;
		}
		public void ListaDeJefes()
		{
			for(int i = 0; i < jefes.Count; i++)
			{
				Console.WriteLine($"Lista de jefes: {jefes[i].Cargo} {jefes[i].Nombre} {jefes[i].Apellido}");
			}
		}
		public void ListaDeObras()
		{
			for(int i = 0; i < obras.Count; i++)
			{
				Console.WriteLine($"{i+1}- {obras[i].NombreObra}");
			}
		}
		public void InfoObras()
		{
			foreach(var obra in obras)
			{
				
				Console.WriteLine($"obra: {obra.NombreObra}, jefe: {obra.Jefe.Nombre} {obra.Jefe.Apellido}");
				obra.MostrarObreros();
			}
			
		}
	}	
}