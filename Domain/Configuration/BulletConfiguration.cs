using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using resume.generator.Domain.Models;

namespace resume.generator.Domain.Configuration
{
    public class BulletConfiguration : IEntityTypeConfiguration<Bullet>
    {
        public void Configure(EntityTypeBuilder<Bullet> builder)
        {
            builder.Property(b => b.Content).HasMaxLength(240).IsRequired();
        }
    }
}