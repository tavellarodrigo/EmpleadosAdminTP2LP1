using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminEmpleadosEntidades
{
    public class Empleado
    {
        /*
         decorados usados

            [Column("nombre_apellido")] 
            [Key]
            [NotMapped] 
            [ForeignKey("Departamento")]
         */

        public int? EmpleadoId { get; set; }
     
        public string? Dni { get; set; }

        [MaxLength(100)]
        public string? Nombre { get; set; }

        [MaxLength(500)]
        public string? Direccion { get; set; }
        
        public DateTime? FechaIngreso { get; set; }        

        [Column(TypeName="decimal(8,2)")]
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

        public bool anulado { get; set; } = false;
    }
}
