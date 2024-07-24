using System;
using System.Collections.Generic;


namespace Empresa_constructora
{
    //atributos
    public class EmpresaConstructora
    {
        protected List<Obra> obras;
        protected List<Jefe_de_Obra> jefes;
        protected List<Obrero> obreros;
        protected GrupoObrero[] grupos;
        protected int contadorCodigoObra;

        //Constructor
        public EmpresaConstructora()
        {
            obras = new List<Obra>();
            jefes = new List<Jefe_de_Obra>();
            obreros = new List<Obrero>();
            contadorCodigoObra = 1;
            grupos = new GrupoObrero[8]; // Inicialización del vector con 8 grupos

            for (int i = 0; i < grupos.Length; i++)
            {
                grupos[i] = new GrupoObrero();
            }

        }
        //Propiedades
        public List<Obra> Obras
        {
            get { return obras; }
            set { obras = value; }
        }
        public List<Jefe_de_Obra> Jefes
        {
            get { return jefes; }
            set { jefes = value; }
        }
         public List<Obrero> Obreros
        {
            get { return obreros; }
            set { obreros = value; }
        }
        public GrupoObrero[] Grupos
        {
            get { return grupos; }
            set { grupos = value; }
        }
        public int ObtenerNuevoCodigoObra()
        {
            return contadorCodigoObra++;
        }
        public void ContratarObrero(Obrero obrero, int num_grupo)
        {
            Obreros.Add(obrero);
            grupos[num_grupo].AsignarAgrupo(obrero);
        }

        public void DespedirObrero(int dni)
        {
            Obrero obrero = Obreros.Find(o => o.Dni == dni);
            if (obrero != null)
            {
                Obreros.Remove(obrero);
                foreach (var grupo in grupos)
                {
                    grupo.EliminarObrero(obrero);
                }
            }
        }
        public void ContratarJefe(Jefe_de_Obra jefe)
        {
                Obreros.Add(jefe);
                jefes.Add(jefe);
           
        }
        public GrupoObrero ObtenerGrupoLibre()
        {
            foreach (var grupo in grupos)
            {
                if (grupo.Obrero.Count > 0 && grupo.CodigoObra == 0)
                {
                    return grupo;
                }
            }
            return null;
        }
        public void EliminarGrupo(int num_grupo){
            GrupoObrero grupo = Array.Find(grupos, g => g.CodigoObra == num_grupo);
            if (grupo != null)
            {
                grupo.LiberarObra();
            }
        }
        public void DespedirJefe(Jefe_de_Obra jefeObra)
        {
                jefes.Remove(jefeObra);
        }
        public void ListaDeJefes()
        {
            for (int i = 0; i < jefes.Count; i++)
            {
                Console.WriteLine(jefes[i].ToString());
            }
        }
        public int CantidadJefes(){
            return jefes.Count;
        }
        public void ListaObras(){
            foreach (var o in obras){
                Console.WriteLine(o);
            }
        }
        public void EliminarObra(int codigo){
            Obra obra = obras.Find(o => o.Codigo_interno == codigo);
            obras.Remove(obra);
        }
        public int CantidadObras()
        {
            return obras.Count;
        }
        public void InfoObras()
        {
            foreach (var obra in obras)
            {

                Console.WriteLine(obra.ToString());
                if(obra.Jefe != null && obra.Jefe.Grupo != null){
                    Console.WriteLine(obra.Jefe.Grupo.ToString());
                }
            }
        }
        public void ListaGrupos()
        {
            foreach (var grupo in grupos)
            {
                
                    Console.WriteLine(grupo.ToString());
                
            }
        }
        public void ListObrero()
        {
            for (int i = 0; i < Obreros.Count; i++)
            {
                Console.WriteLine(Obreros[i].ToString());
            }
        }
        public int CantidadObreros(){
            return obreros.Count;
        }
        //Seteamos el avance de la obra, primero la buscamos con el Find en la lista de obras usando el codigo interno

        public void ListaDEObrasFinalizadas()
        {
            foreach (var obra in obras)
            {
                if (obra.Finalizado == true)
                {
                    Console.WriteLine(obra);
                }
            }
        }
        public void ListaDeObrasEnEjecucion()
        {
            foreach (var obra in obras)
            {
                if (obra.Finalizado == false)
                {
                    Console.WriteLine(obra);
                }
            }
        }

        public double PorcentajeObrasEnEjecucion()
        {
            int remodelacionesSinFinalizar = 0;
            int totalRemodelaciones = 0;
            
            foreach (var obra in obras)
            {
                if (obra.TipoObra == "remodelación")
                {
                    totalRemodelaciones++;
                }

                if (obra.Avance < 100)
                {
                    remodelacionesSinFinalizar++;
                }
            }
            if (totalRemodelaciones > 0)
            {
                double porcentaje=(double)remodelacionesSinFinalizar * 100 / totalRemodelaciones;
                return porcentaje;
            }
            else
            {
                return 0;
            }
        }
    }
}
