using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminEmpleadosEntidades
{
    public  class Departamento
    {
        [Key]
        public int id { get; set; }

        public int dpto_nro { get; set; }

        [Column("nombre_dpto")]        
        public string? Nombre { get; set; }
        
    }
}
