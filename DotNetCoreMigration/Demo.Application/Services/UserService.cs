using Demo.Application.Interfaces.Repositories;
using Demo.Application.Interfaces.Services;
using Demo.Domain.Entities;

namespace Demo.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _repository;

    public UserService(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<User>> GetUsersAsync()
    {
        return await _repository.GetUsersAsync();
    }
}
