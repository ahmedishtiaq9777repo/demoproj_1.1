using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace demoproj_1._1.Models
{
    public partial class moazzandbContext : DbContext
    {
        public virtual DbSet<Employe> Employe { get; set; }
        public virtual DbSet<ImageStore> ImageStore { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Data Source=SQL5047.site4now.net;Initial Catalog=DB_A50611_ahmedishtiaq9777;User Id=DB_A50611_ahmedishtiaq9777_admin;Password=ahmedishtiaq9777;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employe>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Pass)
                    .HasColumnName("pass")
                    .HasMaxLength(50);

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            modelBuilder.Entity<ImageStore>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Imagebase64string).HasColumnName("imagebase64string");
            });
        }
    }
}