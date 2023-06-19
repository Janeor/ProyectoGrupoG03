using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoGrupalG03.Models
{
    public class Sucursal
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public String nombreSucursal { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public String dirección { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public String telefono { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public String horarioApertura { get; set; }

        [Required]
        public Boolean estado { get; set; }
    }
}
