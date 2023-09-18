using AdminEmpleadosEntidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminEmpleadosDatos
{
    public  class DepartamentosDatosEF
    {
        static EmpleadosContext? empleadosContext;

        public static List<Departamento> Get(Departamento d)
        {
            empleadosContext = new EmpleadosContext();

            if (empleadosContext.departamentos == null)
            {
                return new List<Departamento>();
            }

            List<Departamento> list = empleadosContext.departamentos.ToList();

            return list;
        }
    }
}
