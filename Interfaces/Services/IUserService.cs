using DomainModels;

namespace Interfaces.Services
{
    public interface IUserService
    {
        Cycle GetWithInclude();
        Cycle GetWithLoad();
    }
}
