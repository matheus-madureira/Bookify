using Bookify.Domain.Users;

namespace Bookify.Domain.Abstractions.Repositories;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

    void Add(User user);
}
