using System;
using System.Collections.Generic;

namespace Empresa_constructora
{
	//atributos
	public class EmpresaConstructora{
		public List<Clase_obra>  obras;
		public List<Jefe_de_Obra> jefes;
		public List<Clase_Obreros> obreros;
		public List<Clase_grupoObreros> grupos;
		Clase_grupoObreros[] grupo_obrero= new Clase_grupoObreros[8];
		
		//Constructor
		public EmpresaConstructora(){
			obras = new List<Clase_obra>();
			jefes = new List<Jefe_de_Obra>();
			obreros = new List<Clase_Obreros>();
			grupos = new List<Clase_grupoObreros>();
			
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
		public void AgregarObrero(Clase_Obreros nuevoObrero)
		{
			obreros.Add(nuevoObrero);
		}
		public void ListObreros()
		{
			for(int i = 0; i < obreros.Count; i++)
			{
				Console.WriteLine($"{i+1}- {obreros[i].Nombre} {obreros[i].Apellido}, legajo: {obreros[i].NroLegajo}, cargo: {obreros[i].Cargo}");
			}
		}
		public void AsignarObra()
		{
			foreach(var obra in obras)
			{
				foreach(var group in grupos)
				{
					if(group.Codigo_interno == obra.Codigo_interno)
					{
						grupo_obrero[0] = new Clase_grupoObreros();
					}
				}
			}
		}
	}	
}