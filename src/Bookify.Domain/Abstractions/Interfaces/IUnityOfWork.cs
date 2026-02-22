namespace Bookify.Domain.Abstractions.Interfaces;

public interface IUnityOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
