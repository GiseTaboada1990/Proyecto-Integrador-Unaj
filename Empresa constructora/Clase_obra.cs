/*
 * Created by SharpDevelop.
 * User: elizabeth.g.taboada
 * Date: 5/29/2024
 * Time: 5:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Empresa_constructora
{
	/// <summary>
	/// Description of Clase_obras. Chau Mensaje nuevo
	/// </summary>
	
		public class Clase_obra
		{
			//Atributos
			private bool finalizado;
			private double avance, costo;
			private string nombrePropietario;
			private int dni_propietario, codigo_interno;
			
			//Constructor
			public Clase_obra(bool finalizado, double costo, double avance, string nombrePropietario, int dni_propietario, int codigo_interno){
				this.finalizado = finalizado;
				this.avance = avance;
				this.costo = costo;
				this.nombrePropietario = nombrePropietario;
				this.dni_propietario = dni_propietario;
				this.codigo_interno = codigo_interno;
			}
			//Propiedades
			public bool Finalizado{
				get{
					return finalizado;
				}
				set{
					this.finalizado = value;
				}
			}
			public double Avance{
				get{
					return avance;
				}
				set{
					this.avance = value;
				}
			}
			public double Costo{
				get{
					return costo;
				}
				set{
					this.costo = value;
				}
			}
			public string NombrePropietario{
				get{
					return nombrePropietario;
				}
				set{
					this.nombrePropietario = value;
				}
			}
			public int Dni_propietario{
				get{
					return dni_propietario;
				}
				set{
					this.dni_propietario = value;
				}
			}
			public int Codigo_interno{
				get{
					return codigo_interno;
				}
				set{
					this.codigo_interno = value;
				}
			}
	}
}
