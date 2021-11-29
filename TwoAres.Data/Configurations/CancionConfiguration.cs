using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TwoAres.Core;

namespace TwoAres.Data.Configurations
{
    public class CancionConfiguration : IEntityTypeConfiguration<Cancion>
    {
        public void Configure(EntityTypeBuilder<Cancion> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).UseIdentityColumn();

            builder.Property(c => c.Nombre).IsRequired().HasMaxLength(100);

            builder.HasOne(c => c.Artista).WithMany(a => a.Canciones).HasForeignKey(c => c.IdArtista);

            builder.ToTable("Canciones");
        }
    }
}
