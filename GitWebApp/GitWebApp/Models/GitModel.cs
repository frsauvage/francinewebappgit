namespace GitWebApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GitModel : DbContext
    {
        public GitModel()
            : base("name=GitModel")
        {
        }

        public virtual DbSet<COCKPIT_VALEUR> COCKPIT_VALEUR { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<COCKPIT_VALEUR>()
                .Property(e => e.CVA_VALEUR)
                .HasPrecision(15, 3);
        }
    }
}
