using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TwoAres.Data.Data
{
    public partial class TwoAresDbContextFirst : DbContext
    {
        public TwoAresDbContextFirst()
        {
        }

        public TwoAresDbContextFirst(DbContextOptions<TwoAresDbContextFirst> options)
            : base(options)
        {
        }

        public virtual DbSet<Artista> Artista { get; set; }
        public virtual DbSet<Cancion> Cancion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-902IJ86V;Initial Catalog=TwoAres;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artista>(entity =>
            {
                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<Cancion>(entity =>
            {
                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.HasOne(d => d.IdArtistaNavigation)
                    .WithMany(p => p.Cancion)
                    .HasForeignKey(d => d.IdArtista)
                    .HasConstraintName("FK__Cancion__IdArtis__267ABA7A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
