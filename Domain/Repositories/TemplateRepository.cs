using AutoMapper;
using resume.generator.Domain.Dto;
using resume.generator.Domain.Interfaces;
using resume.generator.Domain.Models;

namespace resume.generator.Domain.Repositories
{
    public class TemplateRepository : BaseRepository<Template, TemplateDto>, ITemplateRepository
    {
        public TemplateRepository(ApplicationDbContext context, IUnitOfWork unitOfWork, IMapper mapper) : base(context,
            unitOfWork, mapper) { }
    }
}