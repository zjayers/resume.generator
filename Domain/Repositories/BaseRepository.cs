using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using resume.generator.Domain.Interfaces;
using resume.generator.Domain.Models;

namespace resume.generator.Domain.Repositories
{
    public class BaseRepository<T, TDto> : IRepository<TDto>
        where T : BaseModel
        where TDto : class, new()
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly DbSet<T> entities;

        public BaseRepository(ApplicationDbContext context, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _context = context;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            entities = context.Set<T>();
        }

        public async Task<IEnumerable<TDto>> FetchMany(bool includeRelatedData = true)
        {
            return _mapper.Map<IEnumerable<T>, IEnumerable<TDto>>(await entities.ToListAsync());
        }

        public async Task<TDto> FetchOne(string id, bool includeRelatedData = true)
        {
            var results = await entities.SingleOrDefaultAsync(t => t.Id == Guid.Parse(id));
            return _mapper.Map<T, TDto>(results);
        }

        public async Task<TDto> CreateOne(TDto item)
        {
            // TODO add generic creation
            throw new NotImplementedException();
        }

        public async Task<TDto> UpdateOne(string id, TDto item)
        {
            // TODO
            throw new NotImplementedException();
        }

        public async Task<TDto> DeleteOne(string id)
        {
            // TODO
            throw new NotImplementedException();
        }
    }
}