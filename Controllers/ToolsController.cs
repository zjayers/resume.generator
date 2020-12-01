using resume.generator.Domain.Dto;
using resume.generator.Domain.Interfaces;

namespace resume.generator.Controllers
{
    public class ToolsController : BaseController<ToolDto>
    {
        public ToolsController(IToolRepository repository) : base(repository) { }
    }
}