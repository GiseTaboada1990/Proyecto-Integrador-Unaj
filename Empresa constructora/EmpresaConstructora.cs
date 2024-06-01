/*
 * Created by SharpDevelop.
 * User: elizabeth.g.taboada
 * Date: 5/29/2024
 * Time: 3:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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
		
		//Métodos para recuperar
	}	
}