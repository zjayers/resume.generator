using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using resume.generator.Domain.Models;

namespace resume.generator.Domain.Configuration
{
    public class DatabaseConfiguration : IEntityTypeConfiguration<Database>
    {
        public void Configure(EntityTypeBuilder<Database> builder) { }
    }
}