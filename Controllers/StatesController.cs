using resume.generator.Domain.Dto;
using resume.generator.Domain.Interfaces;

namespace resume.generator.Controllers
{
    public class StatesController : BaseController<StateDto>
    {
        public StatesController(IStateRepository repository) : base(repository) { }
    }
}