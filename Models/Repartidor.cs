using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoGrupalG03.Models
{
    public class Repartidor
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public String nombreRepartidor { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public String dirección { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public String telefono { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public String horarioTrabajo { get; set; }

        public int roleId { get; set; }
        public Role role { get; set; }

        [Required]
        public Boolean estado { get; set; }
    }
}
