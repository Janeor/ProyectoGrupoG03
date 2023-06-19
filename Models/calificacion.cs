using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoGrupalG03.Models
{
    public class calificacion
    {
        public int Id { get; set; }

        [Required]
        public int estrellas { get; set; }
    }
}
