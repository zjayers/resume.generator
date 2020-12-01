using AutoMapper;
using resume.generator.Domain.Dto;
using resume.generator.Domain.Interfaces;
using resume.generator.Domain.Models;

namespace resume.generator.Domain.Repositories
{
    public class StateRepository : BaseRepository<State, StateDto>, IStateRepository
    {
        public StateRepository(ApplicationDbContext context, IUnitOfWork unitOfWork, IMapper mapper) : base(context,
            unitOfWork, mapper) { }
    }
}