using AdminEmpleadosEF;
using AdminEmpleadosEntidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Net.Http.Json;

namespace AdminEmpleadosDatos
{
    public static class EmpleadosDatosEF
    {
        static AdminEmpleadosDBContext? empleadosContext;
        
        public static List<Empleado> Get(Empleado e)
        {
            //empleadosContext = new AdminEmpleadosDBContext();
            //if (empleadosContext.empleado == null)
            //{
            //    return new List<Empleado>();
            //}

            var client = new HttpClient();
            //traer la URL de una config
            //es mejor usar ASYNC, pero en este caso no lo uso para no cambiar la firma del metodo
            List<Empleado> empleadosFromAPI = client.GetFromJsonAsync<List<Empleado>>("http://localhost:5189/api/Empleados").Result;

            if (empleadosFromAPI == null)
            {
                return new List<Empleado>();
            }

            List<Empleado> list;
            if (String.IsNullOrWhiteSpace(e.Nombre) && String.IsNullOrWhiteSpace(e.Dni))
            {
                //list = empleadosContext.empleado.Include("Departamento").Where(e => e.anulado == false).ToList();
                list = empleadosFromAPI.Where(e => e.anulado == false).ToList();
            }
            else
            {

                //list = empleadosContext.empleado.Include("Departamento").Where(i =>
                //    (i.Nombre != null ? i.Nombre.Contains(e.Nombre ?? "") : true)
                //    ||
                //    (i.Dni != null ? i.Dni.Contains(e.Dni ?? "") : true)
                //    ).Where(e => e.anulado == false).ToList();

                list = empleadosFromAPI.Where(i =>
                    (i.Nombre != null ? i.Nombre.Contains(e.Nombre ?? "") : true)
                    ||
                    (i.Dni != null ? i.Dni.Contains(e.Dni ?? "") : true)
                    ).Where(e=>e.anulado == false).ToList();
            }


            return list;
        }

        public static int Insert(Empleado e)
        {
            empleadosContext = new AdminEmpleadosDBContext();

            if (empleadosContext == null)
            {
                return 0;
            }
            //seteo el ID en null para que realice el insert porque si tiene otro valor EF lo toma como un update
            e.EmpleadoId = null;
            e.anulado = false;
            empleadosContext.Add(e);
            empleadosContext.SaveChanges();
            if (e.EmpleadoId == null)
                return 0;

            return (int)e.EmpleadoId;

        }

        public static bool Update(Empleado e)
        {
            empleadosContext = new AdminEmpleadosDBContext();

            var empleadoBD = empleadosContext.empleado.FirstOrDefault(c => c.EmpleadoId == e.EmpleadoId);
            if (empleadoBD == null)
                return false;

            empleadoBD.Direccion = e.Direccion;
            empleadoBD.Dni = e.Dni;
            empleadoBD.Salario = e.Salario;
            empleadoBD.FechaIngreso = e.FechaIngreso;
            empleadoBD.Nombre = e.Nombre;
            empleadoBD.dpto_id = e.dpto_id;
            empleadoBD.anulado = e.anulado;

            empleadosContext.SaveChanges();

            return true;
        }

        public static bool Anular(int id)
        {
            empleadosContext = new AdminEmpleadosDBContext();

            var empleadoBD = empleadosContext.empleado.FirstOrDefault(c => c.EmpleadoId == id);
            if (empleadoBD == null)
                return false;

            empleadoBD.anulado = true;

            empleadosContext.SaveChanges();

            return true;
        }
    }
}
