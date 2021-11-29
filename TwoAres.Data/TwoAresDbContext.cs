using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TwoAres.Core;
using TwoAres.Data.Configurations;

namespace TwoAres.Data
{
    public class TwoAresDbContext : DbContext
    {
        public TwoAresDbContext(DbContextOptions<TwoAresDbContext> options) : base(options) { }
        public DbSet<Cancion> Canciones { get; set; }
        public DbSet<Artista> Artistas { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CancionConfiguration());
            builder.ApplyConfiguration(new ArtistaConfiguration());
        }
    }
}