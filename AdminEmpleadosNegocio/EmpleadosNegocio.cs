using AdminEmpleadosDatos;
using AdminEmpleadosEntidades;

namespace AdminEmpleadosNegocio
{
    public class EmpleadosNegocio
    {
        public static List<Empleado> Get(Empleado e)
        {            
            return EmpleadosDatosEF.Get(e);
        }
    }
}
