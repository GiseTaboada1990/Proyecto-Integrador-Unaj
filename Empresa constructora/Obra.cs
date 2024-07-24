using System;
using System.Collections.Generic;

namespace Empresa_constructora
{
	public class Obra : EmpresaConstructora
	{
		//Atributos
		private bool finalizado;
		private double avance, costo;
		private string nombrePropietario;
		private int dni_propietario, codigo_interno;
		private string tipoObra;
		private Jefe_de_Obra jefe;

		//Constructor
		public Obra(string _nombrePropietario, int _dni_propietario, int _codigo_interno, int _avance, double _costo, string _tipoObra)
		{

			finalizado = false;
			avance = _avance;
			costo = _costo;
			nombrePropietario = _nombrePropietario;
			dni_propietario = _dni_propietario;
			codigo_interno = _codigo_interno;
			jefe = null;
			tipoObra = _tipoObra;
		}
		//Propiedades
			public bool Finalizado
		{
			get
			{
				return finalizado;
			}
			set
			{
				finalizado = value;
			}
		}
		public double Avance
		{
			get
			{
				return avance;
			}
			set
			{
				avance = value;
			}
		}
		public double Costo
		{
			get
			{
				return costo;
			}
		}
		public string NombrePropietario
		{
			get
			{
				return nombrePropietario;
			}
		}
		public int Dni_propietario
		{
			get
			{
				return dni_propietario;
			}
		}
		public int Codigo_interno
		{
			get
			{
				return codigo_interno;
			}
		}
		public string TipoObra
		{
			get { return tipoObra; }
		}
		public Jefe_de_Obra Jefe
		{
			get { return jefe; }
			set { jefe = value; }
		}

		//Método que muestra el avance de cada obra en porcentaje
		public void EstablecerAvance(double nuevoAvance)
        {
            Avance = nuevoAvance;
        }

		//Método que muestra si una obra está finalizada
		public void obraFinalizada()
		{
			Finalizado = true;
		}
		public override string ToString()
		{
			if(Jefe != null){
				return $"Obra {codigo_interno}: Propietario: {nombrePropietario}, Tipo: {tipoObra}, Avance: {avance}%, Jefe: {Jefe.Nombre} {Jefe.Apellido}";
			
			}
			else{
				return $"Obra {codigo_interno}: Propietario: {nombrePropietario}, Tipo: {tipoObra}, Avance: {avance}%";
			}
		}

	}
}
