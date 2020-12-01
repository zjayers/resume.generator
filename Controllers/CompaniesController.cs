using resume.generator.Domain.Dto;
using resume.generator.Domain.Interfaces;

namespace resume.generator.Controllers
{
    public class CompaniesController : BaseController<CompanyDto>
    {
        public CompaniesController(ICompanyRepository repository) : base(repository) { }
    }
}