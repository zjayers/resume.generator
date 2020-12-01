using resume.generator.Domain.Dto;
using resume.generator.Domain.Interfaces;

namespace resume.generator.Controllers
{
    public class CitiesController : BaseController<CityDto>
    {
        public CitiesController(ICityRepository repository) : base(repository) { }
    }
}