using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoGrupalG03.Models
{
    public class metodoPago
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public String metodo { get; set; }

        [Required]
        public Boolean estado { get; set; }
    }
}
