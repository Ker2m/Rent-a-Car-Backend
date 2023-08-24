using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IUserTokenRepository UserTokens { get; }
    ICarsRepository Cars { get; }
    ICommentRepository comment { get; }
    IReservationsRepository Reservations { get; }
    IContactRepository Contact { get; }
    
    

    Task<int> CommitAsync();
}