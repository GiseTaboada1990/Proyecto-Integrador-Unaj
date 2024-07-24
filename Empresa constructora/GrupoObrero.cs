
using System;
using System.Collections.Generic;

namespace Empresa_constructora
{
	public class GrupoObrero
	{
		// atributos
		private List<Obrero> obrero;
		private int codigoObra;
		public GrupoObrero()
        {
            obrero = new List<Obrero>();
			codigoObra = 0;
        }
		public int CodigoObra
		{
			get{return codigoObra;}
			set{ codigoObra = value;}
		}
		public List<Obrero> Obrero
		{
			get{return obrero;}
			set{ obrero = value;}

		}
		public void AsignarAgrupo(Obrero integrante)
		{
			Obrero.Add(integrante);
		}
		public void EliminarObrero(Obrero integrante)
		{
			Obrero.Remove(integrante);
		}
		
		public void AsignarObra(int codigo)
		{
			codigoObra = codigo;
		}
		//Para liberar la obra le seteamos su codigo interno en 0
		public void LiberarObra()
		{
			codigoObra = 0;
			obrero.Clear();
		}
		public override string ToString()
		{
			int contador= 0;
			Console.WriteLine($"Grupo de obra: {CodigoObra}");
			for(int i=0; i<obrero.Count; i++){
				Console.WriteLine(obrero[i].ToString());
				contador++;
			}
			return "";
		}
	}
}
