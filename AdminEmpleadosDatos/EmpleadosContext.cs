using AdminEmpleadosEntidades;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace AdminEmpleadosDatos
{
    public class EmpleadosContext : DbContext
    {

        public DbSet<Empleado> empleados { get; set; }
        public DbSet<Departamento> departamentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString);
        }
    }
}
