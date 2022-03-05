using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Jorge_Estrada.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "El campo categoria es requerido")]
        public string Nombrecategoria { get; set; }
        public string Descripcion { get; set; }    
        public DateTime FechaActual { get; set; }

        
    }
}
