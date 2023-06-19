using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoGrupalG03.Models
{
    public class factura
    {
        public int Id { get; set; }
    
        public int clienteId { get; set; }
        public cliente cliente { get; set; }

        public int sucursalId { get; set; }
        public Sucursal sucursal { get; set; }

        public int productoId { get; set; }
        public producto producto { get; set; }

        public int metodoPagoId { get; set; }
        public metodoPago metodoPago { get; set; }

        public int reseñaId { get; set; }
        public Reseña Reseña { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public String total { get; set; }

        [Required]
        public Boolean estado { get; set; }
    }
}
