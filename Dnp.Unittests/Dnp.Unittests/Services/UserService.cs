using Dnp.Unittests.Dtos;

namespace Dnp.Unittests.Services;

public class UserService : IUserService
{
    public User GetCurrentUser()
    {
        return new User(Guid.NewGuid(), "Frauke");
    }
}
