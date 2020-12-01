using resume.generator.Domain.Dto;
using resume.generator.Domain.Interfaces;

namespace resume.generator.Controllers
{
    public class DatabasesController : BaseController<DatabaseDto>
    {
        public DatabasesController(IDatabaseRepository repository) : base(repository) { }
    }
}