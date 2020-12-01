using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using resume.generator.Domain.Configuration;
using resume.generator.Domain.Models;

namespace resume.generator.Domain
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ApplicationUserConfiguration());
            builder.ApplyConfiguration(new CompanyConfiguration());
            builder.ApplyConfiguration(new JobTitleConfiguration());

            builder.ApplyConfiguration(new SnippetConfiguration());
            builder.ApplyConfiguration(new BulletConfiguration());

            builder.ApplyConfiguration(new TemplateConfiguration());
            builder.ApplyConfiguration(new ToolConfiguration());

            builder.ApplyConfiguration(new DatabaseConfiguration());
            builder.ApplyConfiguration(new LanguageConfiguration());
            builder.ApplyConfiguration(new FrameworkConfiguration());

            base.OnModelCreating(builder);
        }
    }
}