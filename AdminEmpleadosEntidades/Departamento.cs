using System.ComponentModel.DataAnnotations;

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
