using Microsoft.EntityFrameworkCore;
using SysPruebaTecnica.Models;

namespace SysPruebaTecnica.Data
{
    //conexion a base de datos para poder enviar los datos del formulario 
    public class BDContext : DbContext
    {
        public BDContext(DbContextOptions<BDContext> options) : base(options) {
     
        }
        public DbSet<Contacto> Contactos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            // para creacion de base de datos por medio de scanffold

            modelBuilder.Entity<Contacto>(tb => { tb.HasKey(col => col.IdContacto);

                tb.Property(col => col.IdContacto).UseIdentityColumn().ValueGeneratedOnAdd();

                tb.Property(col => col.Nombre).HasMaxLength(50);
            });
        }
    }
}
