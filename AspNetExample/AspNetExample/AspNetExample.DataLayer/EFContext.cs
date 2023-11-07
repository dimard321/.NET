using AspNetExample.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace AspNetExample.DataLayer
{
    /// <summary>
    /// EF контекст сущностей приложения
    /// </summary>
    public class EFContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Mark> Marks { get; set; }

        public EFContext([NotNull] DbContextOptions<EFContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EFContext).Assembly);
        }
    }
}
