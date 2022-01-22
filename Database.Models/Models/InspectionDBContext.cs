
using Database.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.Models.Models
{
    public partial class InspectionDBContext : DbContext
    {
        public InspectionDBContext()
        {
        }

        public InspectionDBContext(DbContextOptions<InspectionDBContext> options) : base(options)
        {

        }

        public virtual DbSet<JobTitle> JobTitle { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobTitle>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}