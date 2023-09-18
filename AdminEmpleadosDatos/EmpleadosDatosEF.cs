using AdminEmpleadosEntidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
