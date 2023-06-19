using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoGrupalG03.Models
{
    public class cliente
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="varchar(10)")]
        public String nombreCliente { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public String dirección { get; set; }
        [Required]
        [Column(TypeName= "varchar(10)")]
        public String telefono { get; set; }
        
        public int roleId { get; set; }
        public Role role { get; set; }

        [Required]
        public Boolean estado { get; set; }
        
    }
}
