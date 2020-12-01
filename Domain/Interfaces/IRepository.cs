using System.Collections.Generic;
using System.Threading.Tasks;

namespace resume.generator.Domain.Interfaces
{
    public interface IRepository<TDto>
        where TDto : class
    {
        Task<IEnumerable<TDto>> FetchMany(bool includeRelatedData = true);
        Task<TDto> FetchOne(string id, bool includeRelatedData = true);
        Task<TDto> CreateOne(TDto item);
        Task<TDto> UpdateOne(string id, TDto item);
        Task<TDto> DeleteOne(string id);
    }
}