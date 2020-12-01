using resume.generator.Domain.Dto;
using resume.generator.Domain.Interfaces;

namespace resume.generator.Controllers
{
    public class FrameworksController : BaseController<FrameworkDto>
    {
        public FrameworksController(IFrameworkRepository repository) : base(repository) { }
    }
}