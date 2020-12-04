using DomainModels;

namespace Interfaces.Repositories
{
    public interface IUserRepository
    {
        Cycle GetWithInclude();
        Cycle GetWithLoad();
    }
}
