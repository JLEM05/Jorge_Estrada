using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jorge_Estrada.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; } 
        public int IdCategoria { get; set; }   
        [StringLength(50)]
        [Required(ErrorMessage ="El campo producto es requerido")]
        public string Nombreproducto { get; set; }
        [StringLength(50)]
        public string Descripcion { get; set; } 
       
        public float Precio { get; set; }   
        public DateTime Fechacreacion { get; set; } 
    }
}
