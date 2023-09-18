using AdminEmpleadosEntidades;
using Microsoft.EntityFrameworkCore;

namespace AdminEmpleadosDatos
{
    public class EmpleadosDatosEF
    {        
        static EmpleadosContext? empleadosContext;


        public static List<Empleado> Get(Empleado e)
        {
            empleadosContext = new EmpleadosContext();

            if (empleadosContext.empleados == null)
            {
                return new List<Empleado>();
            }
            //Lazy Loading
            //List<Empleado> list = empleadosContext.empleados.ToList(); //sin departamentos

            List<Empleado> list = empleadosContext.empleados.Include("Departamento").ToList();

            return list;
        }

        public static int Insert(Empleado e)
        {
            //por las dudas seteo el ID en null para que realice el insert
            e.id = null;
            empleadosContext = new EmpleadosContext();
            empleadosContext.Add(e);
            empleadosContext.SaveChanges();

            return (int)e.id;

        }

        public static bool Update(Empleado e)
        {
            empleadosContext = new EmpleadosContext();

            var empleadoBD = empleadosContext.empleados.FirstOrDefault(c=>c.id ==  e.id);
            if (empleadoBD== null)
                return false;

            empleadoBD.Direccion = e.Direccion;
            empleadoBD.Dni = e.Dni;
            empleadoBD.Salario = e.Salario;
            empleadoBD.FechaIngreso = e.FechaIngreso;
            empleadoBD.Nombre = e.Nombre;            
            empleadoBD.dpto_id = e.dpto_id;

            empleadosContext.SaveChanges();

            return true;
        }
    }
}
