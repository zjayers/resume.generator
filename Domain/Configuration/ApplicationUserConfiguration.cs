using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using resume.generator.Domain.Models;

namespace resume.generator.Domain.Configuration
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            // These properties are required
            builder
                .Property(u => u.FirstName)
                .HasMaxLength(45)
                .IsRequired();

            builder
                .Property(u => u.LastName)
                .HasMaxLength(45)
                .IsRequired();

            // These properties are not required
            builder
                .Property(u => u.LinkedIn)
                .HasMaxLength(100)
                .IsRequired(false);

            builder
                .Property(u => u.Github)
                .HasMaxLength(100)
                .IsRequired(false);

            builder
                .Property(u => u.Portfolio)
                .HasMaxLength(100)
                .IsRequired(false);
        }
    }
}