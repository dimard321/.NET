using AspNetExample.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AspNetExample.DataLayer.Configurations
{
    public class CourseConfigurations : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.Campacity)
                .IsRequired();

            builder.Property(c => c.Date)
                .IsRequired();

            builder.HasMany(c => c.Students)
                .WithMany(s => s.Courses);
        }
    }
}
