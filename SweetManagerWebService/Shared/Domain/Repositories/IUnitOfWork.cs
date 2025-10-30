namespace SweetManagerWebService.Shared.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task CommitAsync();
    }
}
