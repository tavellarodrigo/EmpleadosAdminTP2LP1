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

        public static int Insert(Empleado e)
        {
            if (String.IsNullOrEmpty(e.Nombre))
            {
                return 0;
            }
            if (String.IsNullOrEmpty(e.Dni))
            {
                return 0;
            }
            if (e.FechaIngreso == null)
            {
                e.FechaIngreso = DateTime.Now;
            }

            try
            {
                return EmpleadosDatosEF.Insert(e);                
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static bool Update(Empleado e)
        {
            if (String.IsNullOrEmpty(e.Nombre))
            {
                return false;
            }
            if (String.IsNullOrEmpty(e.Dni))
            {
                return false;
            }
            if (e.FechaIngreso == null)
            {
                e.FechaIngreso = DateTime.Now;
            }

            try
            {
                return EmpleadosDatosEF.Update(e);             
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Anular(int id)
        {
            try
            {
                return EmpleadosDatosEF.Anular(id);
            }
            catch (Exception)
            {
                throw;
            }
 
        }

        public static bool DeleteAnulados()
        {
            try
            {
                return EmpleadosDatosEF.DeleteAnulados();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
