using AdminEmpleadosEF;
using AdminEmpleadosEntidades;
using Microsoft.EntityFrameworkCore;
using System;

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
            //List<Empleado> list = empleadosContext.empleados.ToList(); //sin departamentos

            List<Empleado> list = empleadosContext.empleado.Include("Departamento").ToList();            

            return list;
        }
    }
}
