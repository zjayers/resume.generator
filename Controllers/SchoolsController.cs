using resume.generator.Domain.Dto;
using resume.generator.Domain.Interfaces;

namespace resume.generator.Controllers
{
    public class SchoolsController : BaseController<SchoolDto>
    {
        public SchoolsController(ISchoolRepository repository) : base(repository) { }
    }
}