using AdminEmpleadosEntidades;
using System.Data.SqlClient;

namespace AdminEmpleadosDatos
{
    public class EmpleadosDatos
    {
        public static List<Empleado> Get(Empleado e)
        {
            List<Empleado> list = new List<Empleado>();

            string conString = System.Configuration.ConfigurationManager.
                        ConnectionStrings["conexionDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(conString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand("empleadosGet", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                if (e.id != null)
                    command.Parameters.AddWithValue("@id", e.id);
                if (e.Nombre != null)
                    command.Parameters.AddWithValue("@nombre_apellido", e.Nombre);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Empleado emp = new Empleado();
                        
                        emp.id = Convert.ToInt32(reader["id"]);
                        emp.Nombre = Convert.ToString(reader["nombre_apellido"]);
                        emp.Dni = Convert.ToString(reader["dni"]);
                        if (reader["direccion"].GetType() != typeof(DBNull)) 
                            emp.Direccion = Convert.ToString(reader["direccion"]);
                        if (reader["fecha_ingreso"].GetType() != typeof(DBNull))
                            emp.FechaIngreso = Convert.ToDateTime(reader["fecha_ingreso"]);
                        if (reader["salario"].GetType() != typeof(DBNull))
                            emp.Salario = Convert.ToDecimal(reader["salario"]);                        

                        //El SP tambien me devuelve datos del departamento
                        if (reader["nombre_dpto"].GetType() != typeof(DBNull))
                        {
                            //creo un objeto departamento
                            Departamento dep = new Departamento();
                            dep.id = Convert.ToInt32(reader["dpto_id"]); ;
                            dep.Nombre = Convert.ToString(reader["nombre_dpto"]);
                            //asigno el dpto al empleado
                            emp.Departamento = dep;
                        }

                        list.Add(emp);
                        
                    }
                    reader.Close();
                }
                catch (Exception)
                {
                    throw ;
                }

            }


            return list;
        }
        public static int Insert(Empleado e)
        {
            int idEmpleadoCreado = 0;

            string conString = System.Configuration.ConfigurationManager.
                      ConnectionStrings["conexionDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(conString))
            {                
                SqlCommand command = new SqlCommand("empleadosInsert", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                /*
                 Parametros del SP
                    @dni varchar(50) ,n
	                @nombre_apellido varchar(50),
	                @direccion varchar(50),
	                @fecha_ingreso datetime,
	                @salario numeric(18,2),
	                @dpto_id int
                 */

                if (e.Dni != null)
                    command.Parameters.AddWithValue("@dni", e.Dni);
                if (e.Nombre != null)
                    command.Parameters.AddWithValue("@nombre_apellido", e.Nombre);
                if (e.Direccion != null)
                    command.Parameters.AddWithValue("@direccion", e.Direccion);
                if (e.FechaIngreso != null)
                    command.Parameters.AddWithValue("@fecha_ingreso", e.FechaIngreso);
                if (e.Salario != null)
                    command.Parameters.AddWithValue("@salario", e.Salario);
                if (e.Departamento != null && e.Departamento.id != null)
                    command.Parameters.AddWithValue("@dpto_id", e.Departamento.id);

                try
                {
                    connection.Open();
                    //Realizo el insert y obtengo el ID generado de la BD
                    idEmpleadoCreado = Convert.ToInt32(command.ExecuteScalar());

                }
                catch (Exception)
                {
                    throw;
                }

                return idEmpleadoCreado;
            }
        }
        public static bool Update(Empleado e)
        {
            string conString = System.Configuration.ConfigurationManager.
                      ConnectionStrings["conexionDB"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand("empleadosModificar", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                /*
                 Parametros del SP
                    @id int ,n
                    @dni varchar(50) ,n
                    @nombre_apellido varchar(50),
                    @direccion varchar(50),
                    @fecha_ingreso datetime,
                    @salario numeric(18,2),
                    @dpto_id int
                 */

                if (e.id != null)
                    command.Parameters.AddWithValue("@id", e.id);
                if (e.Dni != null)
                    command.Parameters.AddWithValue("@dni", e.Dni);
                if (e.Nombre != null)
                    command.Parameters.AddWithValue("@nombre_apellido", e.Nombre);
                if (e.Direccion != null)
                    command.Parameters.AddWithValue("@direccion", e.Direccion);
                if (e.FechaIngreso != null)
                    command.Parameters.AddWithValue("@fecha_ingreso", e.FechaIngreso);
                if (e.Salario != null)
                    command.Parameters.AddWithValue("@salario", e.Salario);
                if (e.Departamento != null && e.Departamento.id != null)
                    command.Parameters.AddWithValue("@dpto_id", e.Departamento.id);

                try
                {
                    connection.Open();
                    //Realizo el update
                    command.ExecuteNonQuery();

                }
                catch (Exception)
                {
                    throw;
                }                
            }

            return true;
        }
    
    }
}
