using AdminEmpleadosDatos;
using AdminEmpleadosEntidades;

namespace AdminEmpleadosNegocio
{
    public class DepartamentosNegocio
    {
        public static List<Departamento> Get()
        {
            return DepartamentoDatosEF.Get();
        }
    }
}
