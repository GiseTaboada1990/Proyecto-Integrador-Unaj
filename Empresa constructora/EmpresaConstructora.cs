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