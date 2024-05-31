/*
 * Created by SharpDevelop.
 * User: elizabeth.g.taboada
 * Date: 5/29/2024
 * Time: 3:44 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Empresa_constructora
{
	//atributos
	public class EmpresaConstructora{
		private ArrayList obreros, obras, grupoDeObreros;
		//Constructor
		public Clase_empresaConstructora(){
			this.obreros = new ArrayList();
			this.obras = new ArrayList();
			this.grupoDeObreros = new ArrayList();
		}
		//Propiedades
		public ArrayList obreros{
			get{
		}
			set{
				
			}
	}
		public ArrayList obras{
			get{
				
			}
			set{
				
			}
		}
		public ArrayList grupoDeObreros{
			get{
				
			}
			set{
				
			}
		}
		//Métodos para agregar
		public void agregarObra(clase_obra nuevo){
			obras.Add(nuevo);
		}
		public void agregarObrero(clase_obrero nuevo){
			obreros.Add(nuevo);
		}
		public void agregarGrupoDeObreros(clase_grupoObreros nuevo){
			grupoDeObreros.Add(nuevo);
		}
		//Métodos para eliminar
		public void eliminarObra(clase_obra obra){
			obras.Remove(obra);
		}
		public void eliminarObrero(clase_obrero obrero){
			obreros.Remove(obrero);
		}
		public void eliminarGruposObreros(clase_grupoObreros gruposDeObreros){
			grupoDeObras.Remove(grupoDeObreros);
		}
		//Métodos para recuperar
	}	
}