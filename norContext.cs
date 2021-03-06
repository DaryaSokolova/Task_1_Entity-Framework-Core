using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace FirstApp
{
    public partial class norContext : DbContext
    {
        public norContext()
        {
        }

        public norContext(DbContextOptions<norContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Direction> Directions { get; set; }
        public virtual DbSet<Station> Stations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-HO5676A\\SQL_EXPRESS;Database=nor;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Direction>(entity =>
            {
                entity.ToTable("Direction");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Station>(entity =>
            {
                entity.ToTable("Station");

                entity.Property(e => e.Name).IsRequired();

                //entity.HasOne(d => d.DirectionNavigation)
                //    .WithMany(p => p.Stations)
                //    .HasForeignKey(d => d.Direction)
                //    .HasConstraintName("FK_Station");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
