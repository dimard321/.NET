using AspNetExample.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetExample.DataLayer.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(s => s.Surname)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(s => s.Age)
                .IsRequired();

            builder.Property(s => s.Gender)
                .IsRequired();
            
        }
    }
}
