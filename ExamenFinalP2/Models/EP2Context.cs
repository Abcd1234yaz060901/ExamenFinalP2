using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ExamenFinalP2.Models
{
    public class EP2Context : DbContext
    {
        public EP2Context() : base("EP2Context") { }
        public DbSet<Areas> Areas { get; set; }
        public DbSet<Visitante> Visitantes { get; set; }
        public DbSet<Visitas> Visitas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // configures one-to-many relationship
            modelBuilder.Entity<Visitas>()
                .HasRequired<Visitante>(s => s.Visitante)
                .WithMany(g => g.Visitas)
                .HasForeignKey<int>(s => s.IDVisitante);

            modelBuilder.Entity<Visitas>()
               .HasRequired<Areas>(s => s.Areas)
               .WithMany(g => g.Visitas)
               .HasForeignKey<int>(s => s.IDArea);
        }
    }
}
      