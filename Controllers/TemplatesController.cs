using resume.generator.Domain.Dto;
using resume.generator.Domain.Interfaces;

namespace resume.generator.Controllers
{
    public class TemplatesController : BaseController<TemplateDto>
    {
        public TemplatesController(ITemplateRepository repository) : base(repository) { }
    }
}