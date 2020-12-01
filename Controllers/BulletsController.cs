using resume.generator.Domain.Dto;
using resume.generator.Domain.Interfaces;

namespace resume.generator.Controllers
{
    public class BulletsController : BaseController<BulletDto>
    {
        public BulletsController(IBulletRepository repository) : base(repository) { }
    }
}