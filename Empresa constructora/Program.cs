using System;
using Empresa_constructora;


public class Program
{
    public static void Main(string[] args)
    {
        EmpresaConstructora empresa = new EmpresaConstructora();

        CargarDatos(empresa);
        while (true)
        {
            // Mostrar menú de opciones
            Console.WriteLine("\nMenú de opciones:");
            Console.WriteLine("1. Crear una nueva obra");
            Console.WriteLine("2. Contratar un obrero nuevo");
            Console.WriteLine("3. Eliminar un obrero");
            Console.WriteLine("4. Contratar a un jefe de obra");
            Console.WriteLine("5. Dar de baja a un jefe");
            Console.WriteLine("6. Modificar el estado de avance de una obra");
            Console.WriteLine("7. Submenú de impresión");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            // Leer opción seleccionada
            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    CrearObra(empresa);
                    break;
                case "2":
                    ContratarObrero(empresa);
                    break;
                case "3":
                    EliminarObrero(empresa);
                    break;
                case "4":
                    ContratarJefe_de_Obra(empresa);
                    break;
                case "5":
                    DarBajaJefe(empresa);
                    break;
                case "6":
                    ModificarEstadoAvanceObra(empresa);
                    break;
                case "7":
                    SubmenuImpresion(empresa);
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
    //Método para hacer carga de información previa a la visualización del menú
    public static void CargarDatos(EmpresaConstructora empresa)
    {
        int contador = 0;
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Cargar datos de los obreros");
            ContratarObrero(empresa);
            ContratarObrero(empresa);
            Console.WriteLine("Cargar datos de la obra");
            CrearObra(empresa);
            Console.WriteLine("Cargar datos del jefe de obra");
            ContratarJefe_de_Obra(empresa);
            contador++;
        }
    }
    // Método para contratar un nuevo obrero
    public static void ContratarObrero(EmpresaConstructora empresa)
    {
        try
        {
            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Ingrese DNI: ");
            int dni = int.Parse(Console.ReadLine());
            Console.Write("Ingrese número de legajo: ");
            int nroLegajo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese sueldo: ");
            double sueldo = double.Parse(Console.ReadLine());
            Console.Write("Ingrese cargo (capataz, albañil, peón, plomero, electricista, etc.): ");
            string cargo = Console.ReadLine();
            Console.Write("Ingrese el número de grupo desigando (DE 0 A 7): ");
            int num_grupo = int.Parse(Console.ReadLine());
            Obrero obrero = new Obrero(nombre, apellido, dni, nroLegajo, sueldo, cargo);

            if (num_grupo < 0 || num_grupo > 7)
            {
                throw new ArgumentException("El número de grupo ingresado no existe");
            }
            empresa.ContratarObrero(obrero, num_grupo);

            Console.WriteLine("Obrero contratado exitosamente.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // Método para eliminar un obrero
    public static void EliminarObrero(EmpresaConstructora empresa)
    {
        try
        {
            Console.Write("Ingrese DNI del empleado de obra a dar de baja: ");
            int dni = int.Parse(Console.ReadLine());
            var obrero = empresa.Obreros.Find(o => o.Dni == dni);
            if (obrero != null)
            {
                empresa.DespedirObrero(dni);
                Console.WriteLine("Empleado dado de baja exitosamente.");
            }
            else
            {
                Console.WriteLine("El dni ingresado no se encuentra en nuestra base de datos");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // Método para crear una nueva obra
    public static void CrearObra(EmpresaConstructora empresa)
    {
        try
        {
            Console.Write("Ingrese nombre y apellido del propietario: ");
            string nombrePropietario = Console.ReadLine();
            Console.Write("Ingrese DNI del propietario: ");
            int dniPropietario = int.Parse(Console.ReadLine());
            Console.Write("Ingrese costo de la obra: ");
            double costo = double.Parse(Console.ReadLine());
            Console.Write("Ingrese tipo de obra (construcción, remodelación, ampliación, etc.): ");
            string tipoObra = Console.ReadLine();

            int codigoInterno = empresa.ObtenerNuevoCodigoObra();
            Obra obra = new Obra(nombrePropietario, dniPropietario, codigoInterno, 0, costo, tipoObra);
            empresa.Obras.Add(obra);
            Console.WriteLine($"Obra creada exitosamente con código interno {codigoInterno}.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
    }


    // Método para contratar un nuevo jefe de obra
    public static void ContratarJefe_de_Obra(EmpresaConstructora empresa)
    {
        try
        {
            Console.Write("Ingrese nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese apellido: ");
            string apellido = Console.ReadLine();
            Console.Write("Ingrese DNI: ");
            int dni = int.Parse(Console.ReadLine());
            Console.Write("Ingrese número de legajo: ");
            int nroLegajo = int.Parse(Console.ReadLine());
            Console.Write("Ingrese sueldo: ");
            double sueldo = double.Parse(Console.ReadLine());
            Console.Write("Ingrese cargo: ");
            string cargo = Console.ReadLine();
            Console.Write("Ingrese bonificación: ");
            double bonificacion = double.Parse(Console.ReadLine());

            Jefe_de_Obra jefe = new Jefe_de_Obra(nombre, apellido, dni, nroLegajo, sueldo, cargo, bonificacion);

            Console.Write("Ingrese código de la obra a asignar: ");
            int codigoObra = int.Parse(Console.ReadLine());
            Obra obra = empresa.Obras.Find(o => o.Codigo_interno == codigoObra);

            if (obra != null && obra.Jefe == null)
            {
                try
                {
                    empresa.ContratarJefe(jefe);
                    obra.Jefe = jefe;
                    obra.Jefe.Grupo = empresa.ObtenerGrupoLibre();
                    obra.Jefe.Grupo.AsignarObra(obra.Codigo_interno);
                    Console.WriteLine("Jefe de obra contratado exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Obra no encontrada o ya tiene un jefe asignado");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
    }

    // Método para mostrar el submenú de impresión
    public static void SubmenuImpresion(EmpresaConstructora empresa)
    {
        while (true)
        {
            Console.WriteLine("\nSubmenú de impresión:");
            Console.WriteLine("1. Listado de obreros");
            Console.WriteLine("2. Listado de obras en ejecución");
            Console.WriteLine("3. Listado de obras finalizadas");
            Console.WriteLine("4. Listado de jefes");
            Console.WriteLine("5. Listado de grupos de obreros");
            Console.WriteLine("6. Porcentaje de obras de remodelación sin finalizar");
            Console.WriteLine("7. Información de grupo de obreros por cada obra");
            Console.WriteLine("0. Volver");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    if (empresa.ListObrero != null)
                    {

                        empresa.ListObrero();
                    }
                    else
                    {
                        Console.WriteLine("No hay obreros contratados aun.");
                    }
                    break;
                case "2":
                    if (empresa.ListaDeObrasEnEjecucion != null)
                    {

                        empresa.ListaDeObrasEnEjecucion();
                    }
                    else
                    {
                        Console.WriteLine("Aun no hay obras en ejecución");
                    }
                    break;
                case "3":
                    if (empresa.ListaDEObrasFinalizadas != null)
                    {
                        empresa.ListaDEObrasFinalizadas();
                    }
                    else
                    {
                        Console.WriteLine("No hay obras finalizadas");
                    }
                    break;
                case "4":
                    if (empresa.ListaDeJefes != null)
                    {

                        empresa.ListaDeJefes();
                    }
                    else
                    {
                        Console.WriteLine("No hay jefes contratados aun.");
                    }
                    break;
                case "5":
                    empresa.ListaGrupos();
                    break;
                case "6":
                    double porcentaje = empresa.PorcentajeObrasEnEjecucion();
                    Console.WriteLine($"Porcentaje de remodelaciones sin finalizar: {porcentaje}%");
                    break;
                case "7":
                    if (empresa.InfoObras != null)
                    {
                        empresa.InfoObras();
                    }
                    else
                    {
                        Console.WriteLine("No hay información para mostrar.");
                    }
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
    // Método para modificar el estado de avance de una obra
    public static void ModificarEstadoAvanceObra(EmpresaConstructora empresa)
    {
        try
        {
            Console.Write("Ingrese código de la obra: ");
            int codigoObra = int.Parse(Console.ReadLine());
            Console.Write("Ingrese nuevo estado de avance (0-100): ");
            double nuevoEstado = double.Parse(Console.ReadLine());
            var obra = empresa.Obras.Find(ob => ob.Codigo_interno == codigoObra);
            if (obra == null)
            {
                throw new Exception("La obra ingresada no existe");
            }
            if (nuevoEstado >= 0 && nuevoEstado <= 100)
            {
                obra.EstablecerAvance(nuevoEstado);
                obra.Avance = nuevoEstado;
                if (nuevoEstado == 100)
                {
                    obra.obraFinalizada();
                }
            }
            else
            {
                throw new Exception("El avance debe estar en el rango de 0 a 100.");
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
//hola

    // Método para dar de baja a un jefe de obra
    public static void DarBajaJefe(EmpresaConstructora empresa)
    {
        try
        {
            Console.Write("Ingrese DNI del jefe de obra a dar de baja: ");
            int dni = int.Parse(Console.ReadLine());
            var jefe = empresa.Jefes.Find(o => o.Dni == dni);
            if (jefe != null && jefe.Dni == dni)
            {
                foreach (var o in empresa.Obras)
                {
                    if (o.Jefe == jefe)
                    {
                        o.Jefe = null;//Eliminamos al jefe de la obra asignada
                    }
                }
                empresa.DespedirJefe(jefe);
                jefe.EliminarGrupoObrero();
                empresa.Obreros.Remove(jefe);
                GrupoObrero grupo = jefe.Grupo;
                if (grupo != null)
                {
                    grupo.LiberarObra();
                }
                Console.WriteLine("Jefe de obra dado de baja exitosamente.");
            }
            else
            {
                Console.WriteLine("El dni ingresado no se encuentra en nuestra base de datos");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
        }
    }
}

//ya cntrata bien al obrero y se le asigna un grupo
//contrata bien el jefe, se le asigna el grupo, pero debo crear la excepcion para cuando no hay grupos disponibles
//Debo corregir lo del porcentaje
//Revisar cómo se crean los grupos, si estan bien organizados con el número que se le asigna
//Agregar al menú una lista para visualizar los grupos de obreros
