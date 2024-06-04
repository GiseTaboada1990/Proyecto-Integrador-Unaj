using System;
using System.Collections;

namespace Empresa_constructora{

    public class Jefe_de_Obra : Clase_Obreros
    {
       private double bonificacion;
       private Clase_grupoObreros grupo;
       
       public double Bonifcacion
       {
        get{ return bonificacion;}
        set{ bonificacion = value;}
       }
       public Clase_grupoObreros Grupo
       {
        get{ return grupo;}
       }
       public  Jefe_de_Obra(string _nombre, string _apellido, int _dni, int _nroLegajo, double _sueldo, string _cargo, double _bonificacion) : base(_nombre,_apellido,_dni,_nroLegajo,_sueldo,_cargo)
       {
<<<<<<< HEAD
        grupo = new Clase_grupoObreros();
=======
            bonificacion = _bonificacion;
            grupo = new Clase_grupoObreros();
>>>>>>> gadiel2
       }
       public void AgregarObrero(Clase_Obreros obrero)
        {
            grupo.AsignarObreroAgrupo(obrero);
        }

        public void MostrarObreros()
        {
            grupo.MostrarObreros();
        }
    }
}