using resume.generator.Domain.Dto;
using resume.generator.Domain.Interfaces;

namespace resume.generator.Controllers
{
    public class UsersController : BaseController<ApplicationUserDto>
    {
        public UsersController(IApplicationUserRepository repository) : base(repository) { }
    }
}