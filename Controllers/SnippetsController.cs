using resume.generator.Domain.Dto;
using resume.generator.Domain.Interfaces;

namespace resume.generator.Controllers
{
    public class SnippetsController : BaseController<SnippetDto>
    {
        public SnippetsController(ISnippetRepository repository) : base(repository) { }
    }
}