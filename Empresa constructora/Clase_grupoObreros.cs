﻿/*
 * Created by SharpDevelop.
 * User: elizabeth.g.taboada
 * Date: 5/29/2024
 * Time: 6:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Empresa_constructora
{
	/// <summary>
	/// Description of Clase_grupoObreros.
	/// </summary>
	public class Clase_grupoObreros
	{
		// atributos
		private ArrayList integrantes;
		private int codigo_interno;
		
		//Constructor
		public Clase_grupoObreros(ArrayList integrantes, int codigo_interno)
		{
			this.codigo_interno = codigo_interno;
			this.integrantes = integrantes;
		}
		public ArrayList Integrantes{
			get{
				return integrantes;

			}
		}
		public int Codigo_interno{
			get{
				return codigo_interno;
			}
		}
		
	}
}
