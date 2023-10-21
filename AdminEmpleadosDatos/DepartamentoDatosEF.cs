using AdminEmpleadosEF;
using AdminEmpleadosEntidades;

namespace AdminEmpleadosDatos
{
    public  class DepartamentoDatosEF
    {
        static AdminEmpleadosDBContext? empleadosContext;

        public static List<Departamento> Get()
        {
            empleadosContext = new AdminEmpleadosDBContext();

            if (empleadosContext.departamento == null)
            {
                return new List<Departamento>();
            }
            
            List<Departamento> list = empleadosContext.departamento.ToList();

            return list;
        }
    }
}
