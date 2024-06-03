using System;
using System.Collections.Generic;

namespace Empresa_constructora
{
		public class Clase_obra : EmpresaConstructora
		{
			//Atributos
			private string nombreObra;
			private bool finalizado;
			private double avance, costo;
			private string nombrePropietario;
			private int dni_propietario, codigo_interno;
			private Jefe_de_Obra jefe;
			
			//Propiedades
			public string NombreObra{
				get{
					return nombreObra;
				}
				set{
					nombreObra = value;
				}
			}
			public Jefe_de_Obra Jefe
			{
				get{ return jefe;}
				set{ jefe = value;}
			}
			public bool Finalizado{
				get{
					return finalizado;
				}
				set{
					finalizado = value;
				}
			}
			public double Avance{
				get{
					return avance;
				}
				set{
					avance = value;
				}
			}
			public double Costo{
				get{
					return costo;
				}
				set{
					costo = value;
				}
			}
			public string NombrePropietario{
				get{
					return nombrePropietario;
				}
				set{
					nombrePropietario = value;
				}
			}
			public int Dni_propietario{
				get{
					return dni_propietario;
				}
				set{
					dni_propietario = value;
				}
			}
			public int Codigo_interno{
				get{
					return codigo_interno;
				}
				set{
					codigo_interno = value;
				}
			}
			public void CrearObra(Jefe_de_Obra jefe,string nombreObra,bool finalizado, double costo, double avance, string nombrePropietario, int dni_propietario, int codigo_interno){
				this.jefe = jefe;
				this.nombreObra = nombreObra;
				this.finalizado = finalizado;
				this.avance = avance;
				this.costo = costo;
				this.nombrePropietario = nombrePropietario;
				this.dni_propietario = dni_propietario;
				this.codigo_interno = codigo_interno;
			}
			public void EstablecerAvance(double nuevoAvance)
			{
				avance = nuevoAvance;
				Console.WriteLine($"avance: {avance}");
			}
			public void MostrarObreros()
			{
				jefe.MostrarObreros();
			}
	}
}
