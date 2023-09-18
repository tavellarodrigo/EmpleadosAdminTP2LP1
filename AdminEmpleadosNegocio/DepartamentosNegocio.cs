using AdminEmpleadosDatos;
using AdminEmpleadosEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminEmpleadosNegocio
{
    public  class DepartamentosNegocio
    {
        public static List<Departamento> Get(Departamento d)
        {
            try
            {
                return DepartamentosDatosEF.Get(d);
                //return DepartamentosDatos.Get(d);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
