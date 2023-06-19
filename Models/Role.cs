using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoGrupalG03.Models
{
    public class Role
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public String nombreRol { get; set; }
    }
}
