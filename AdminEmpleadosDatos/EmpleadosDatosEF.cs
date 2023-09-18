using AdminEmpleadosEntidades;
using Microsoft.EntityFrameworkCore;
using System;

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
    }
}
