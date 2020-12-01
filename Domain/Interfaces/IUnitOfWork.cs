using System.Threading.Tasks;

namespace resume.generator.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}