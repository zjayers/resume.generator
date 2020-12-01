using resume.generator.Domain.Dto;
using resume.generator.Domain.Interfaces;

namespace resume.generator.Controllers
{
    public class LanguagesController : BaseController<LanguageDto>
    {
        public LanguagesController(ILanguageRepository repository) : base(repository) { }
    }
}