using Microsoft.EntityFrameworkCore;
using ProyectoGrupalG03.Models;

namespace ProyectoGrupoG03.Models
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<cliente> cliente { get; set; }
        public DbSet<calificacion> calificacion { get; set; }
        public DbSet<factura> factura { get; set; }
        public DbSet<metodoPago> metodoPago { get; set; }
        public DbSet<pedido> pedido { get; set; }
        public DbSet<producto> producto { get; set; }
        public DbSet<Repartidor> Repartidor { get; set; }
        public DbSet<Reseña> Reseña { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Sucursal> Sucursal { get; set; }

    }
}
