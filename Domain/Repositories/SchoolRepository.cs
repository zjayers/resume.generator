using AutoMapper;
using resume.generator.Domain.Dto;
using resume.generator.Domain.Interfaces;
using resume.generator.Domain.Models;

namespace resume.generator.Domain.Repositories
{
    public class SchoolRepository : BaseRepository<School, SchoolDto>, ISchoolRepository
    {
        public SchoolRepository(ApplicationDbContext context, IUnitOfWork unitOfWork, IMapper mapper) : base(context,
            unitOfWork, mapper) { }
    }
}