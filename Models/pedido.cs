using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoGrupalG03.Models
{
    public class pedido
    {
        public int Id { get; set; }

        public int clienteId { get; set; }
        public cliente cliente { get; set; }

        public int productoId { get; set; }
        public producto produto { get; set; }

        public int metodoPagoId { get; set; }
        public metodoPago metodoPago { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(100)")]
        public String especificaciones { get; set; }

        [Required]
        public Boolean estado { get; set; }
    }
}
