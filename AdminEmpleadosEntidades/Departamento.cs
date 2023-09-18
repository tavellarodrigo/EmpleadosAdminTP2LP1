using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AdminEmpleadosEntidades
{
    public class Departamento
    {
        [Key]
        public int id { get; set; }

        public int dpto_nro { get; set; }

        [Column("nombre_dpto")]
        public string? Nombre { get; set; }

    }
}
