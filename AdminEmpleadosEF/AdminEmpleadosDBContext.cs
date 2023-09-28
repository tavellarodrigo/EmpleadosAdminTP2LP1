using AdminEmpleadosEntidades;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace AdminEmpleadosEF
{
    public class AdminEmpleadosDBContext : DbContext
    {     
        public DbSet<Empleado> empleado { get; set; }
        public DbSet<Departamento> departamento { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            optionsBuilder.UseSqlServer(connString);

        }
    }
}
