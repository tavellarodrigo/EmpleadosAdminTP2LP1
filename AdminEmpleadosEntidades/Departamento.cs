using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminEmpleadosEntidades
{
    public  class Departamento
    {
        [Key]
        public int DepartamentoId { get; set; }

        public int dpto_nro { get; set; }
        
        public string? Nombre { get; set; }
        
    }
}
