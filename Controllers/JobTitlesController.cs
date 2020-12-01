using resume.generator.Domain.Dto;
using resume.generator.Domain.Interfaces;

namespace resume.generator.Controllers
{
    public class JobTitlesController : BaseController<JobTitleDto>
    {
        public JobTitlesController(IJobTitleRepository repository) : base(repository) { }
    }
}