using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using resume.generator.Domain.Dto;
using resume.generator.Domain.Interfaces;

namespace resume.generator.Domain.Repositories
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        public Task<IEnumerable<ApplicationUserDto>> FetchMany(bool includeRelatedData = true)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUserDto> FetchOne(string id, bool includeRelatedData = true)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUserDto> CreateOne(ApplicationUserDto item)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUserDto> UpdateOne(string id, ApplicationUserDto item)
        {
            throw new NotImplementedException();
        }

        public Task<ApplicationUserDto> DeleteOne(string id)
        {
            throw new NotImplementedException();
        }
    }
}