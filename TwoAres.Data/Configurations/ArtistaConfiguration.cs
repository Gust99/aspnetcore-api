using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TwoAres.Core;

namespace TwoAres.Data.Configurations
{
    public class ArtistaConfiguration : IEntityTypeConfiguration<Artista>
    {
        public void Configure(EntityTypeBuilder<Artista> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).UseIdentityColumn();
            builder.Property(a => a.Nombre).IsRequired().HasMaxLength(100);
            builder.ToTable("Artistas");
        }
    }
}
