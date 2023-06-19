using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoGrupalG03.Models
{
    public class Reseña
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(300)")]
        public String reseña { get; set; }
        public int calificacionId { get; set; }
        public calificacion calificacion { get; set; }
    }
}
