using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ControlMigracion.Data
{
    public class ControlMigracionContext : DbContext
    {
        public ControlMigracionContext(DbContextOptions<ControlMigracionContext> options)
            : base(options)
        {
        }

        public DbSet<Rol> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Viajero> Viajeros { get; set; }
        public DbSet<Lugar> Lugares { get; set; }
        public DbSet<Movimiento> EntradasSalidas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movimiento>()
                .Property(m => m.TipoMovimiento)
                .HasCheckConstraint("CHK_TipoMovimiento", "TipoMovimiento IN ('Entrada', 'Salida')");
        }
    }
}

