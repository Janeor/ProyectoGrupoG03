using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoGrupalG03.Models
{
    public class producto
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public String nombreProducto { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public String descripción { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public String precio { get; set; }
        [Required]
        [Column(TypeName = "varchar(2)")]
        public String Disponibilidad { get; set; }

        [Required]
        public Boolean estado { get; set; }
    }
}
