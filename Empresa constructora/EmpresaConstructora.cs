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
		public static void reclutar_obrero()
            {
                string nombre, apellido, cargo;
                int legajo, dni;
                double sueldo;
                Console.Write("ingrese el nombre del nuevo obrero: ");
                nombre = Console.ReadLine();
                Console.Write("ingrese el apellido del nuevo obrero: ");
                apellido = Console.ReadLine();
                Console.Write("ingrese el DNI del nuevo obrero: ");
                dni = int.Parse(Console.ReadLine());
                Console.Write("ingrese el cargo del nuevo obrero: ");
                cargo = Console.ReadLine();
                Console.Write("ingrese el sueldo del nuevo obrero: ");
                sueldo = double.Parse(Console.ReadLine());
                Console.Write("ingrese el numero de legajo del nuevo obrero: ");
                legajo = int.Parse(Console.ReadLine());
                Clase_Obreros obrero = new Clase_Obreros(nombre,apellido,dni,legajo,sueldo,cargo);
                Console.WriteLine("El obrero " + nombre + " y DNI Nº " + dni + " se creo correctamente" );
            }
			public static void reclutar_Jefe_de_obra()
            {
                string nombre, apellido, cargo;
                int legajo, dni;
                double sueldo, bonificacion;
                Console.Write("ingrese el nombre del nuevo Jefe de obra: ");
                nombre = Console.ReadLine();
                Console.Write("ingrese el apellido del nuevo Jefe de obra: ");
                apellido = Console.ReadLine();
                Console.Write("ingrese el DNI del nuevo Jefe de obra: ");
                dni = int.Parse(Console.ReadLine());
                Console.Write("ingrese el cargo del nuevo Jefe de obra: ");
                cargo = Console.ReadLine();
                Console.Write("ingrese el sueldo del nuevo Jefe de obra: ");
                sueldo = double.Parse(Console.ReadLine());
                Console.Write("ingrese el numero de legajo del nuevo Jefe de obra: ");
                legajo = int.Parse(Console.ReadLine());
				Console.Write("ingrese la bonificacion de sueldo del nuevo Jefe de obra: ");
                bonificacion = double.Parse(Console.ReadLine());
                Jefe_de_Obra Jefe = new Jefe_de_Obra(nombre,apellido,dni,legajo,sueldo,cargo,bonificacion);
                Console.WriteLine("El Jefe de obra " + nombre + " y DNI Nº " + dni + " se creo correctamente" );
            }
	}	
}