namespace COMP2084_FinalExam.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class League : DbContext
    {
        public League()
            : base("name=League")
        {
        }

        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Division>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Division>()
                .HasMany(e => e.Teams)
                .WithRequired(e => e.Division)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.Logo)
                .IsUnicode(false);
        }
    }
}
