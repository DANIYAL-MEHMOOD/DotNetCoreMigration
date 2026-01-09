using Demo.Application.Interfaces.Repositories;
using Demo.Domain.Entities;

namespace Demo.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    public async Task<IEnumerable<User>> GetUsersAsync()
    {
        // Simulate stored procedure result
        var users = new List<User>
        {
            new User { Id = 1, Name = "John", Email = "john@test.com" },
            new User { Id = 2, Name = "Sara", Email = "sara@test.com" }
        };

        return await Task.FromResult(users);
    }
}
