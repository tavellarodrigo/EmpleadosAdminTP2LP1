using AdminEmpleadosEF;
using AdminEmpleadosEntidades;
using Microsoft.EntityFrameworkCore;

namespace AdminEmpleadosDatos
{
    public static class EmpleadosDatosEF
    {
        static AdminEmpleadosDBContext? empleadosContext;

        public static List<Empleado> Get(Empleado e)
        {
            empleadosContext = new AdminEmpleadosDBContext();            

            if (empleadosContext.empleado == null)
            {
                return new List<Empleado>();
            }
            //Lazy Loading
            //List<Empleado> list = empleadosContext.empleado.ToList(); //sin departamentos

            List<Empleado> list = empleadosContext.empleado.Include("Departamento").ToList();            

            return list;
        }

        public static int Insert(Empleado e)
        {
            empleadosContext = new AdminEmpleadosDBContext();

            if (empleadosContext.empleado == null)
            {
                return 0;
            }
            //seteo el ID en null para que realice el insert porque si tiene otro valor EF lo toma como un update
            e.EmpleadoId = null;            
            empleadosContext.Add(e);
            empleadosContext.SaveChanges();
            if (e.EmpleadoId == null)
                return 0;

            return (int)e.EmpleadoId;

        }
    }
}
