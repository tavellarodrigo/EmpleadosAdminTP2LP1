using System.ComponentModel.DataAnnotations.Schema;

namespace AdminEmpleadosEntidades
{
    public class Empleado
    {

        public int? id { get; set; }

        public string? Dni { get; set; }

        [Column("nombre_apellido")] //EF
        public string? Nombre { get; set; }

        public string? Direccion { get; set; }

        [Column("fecha_ingreso")] //EF
        public DateTime? FechaIngreso { get; set; }

        public decimal? Salario { get; set; }

        [ForeignKey("Departamento")] //EF
        public int? dpto_id { get; set; }

        public Departamento? Departamento { get; set; }

        [NotMapped] //EF
        //este campo es para la grilla porque no tiene la inteligencia de mostrar el nombre del dpto usando el objeto "Departamento"
        public string? NombreDepartamento
        {
            get
            {
                if (Departamento != null)
                    return Departamento.Nombre;
                else
                    return null;
            }
        }
        public bool? anulado { get; set; }
    }
}
