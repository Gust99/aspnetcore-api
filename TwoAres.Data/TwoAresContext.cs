using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TwoAres.Core.Entities;

namespace TwoAres.Data
{
    public partial class TwoAresContext : DbContext
    {
        public TwoAresContext()
        {
        }

        public TwoAresContext(DbContextOptions<TwoAresContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Artista> Artista { get; set; }
        public virtual DbSet<Cancion> Cancion { get; set; }       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artista>(entity =>
            {
                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<Cancion>(entity =>
            {
                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.HasOne(d => d.IdArtistaNavigation)
                    .WithMany(p => p.Cancion)
                    .HasForeignKey(d => d.IdArtista)
                    .HasConstraintName("FK_Cancion_Artista");
            });
        }
    }
}
