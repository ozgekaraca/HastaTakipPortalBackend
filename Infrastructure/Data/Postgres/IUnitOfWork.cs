using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IUserTokenRepository UserTokens { get; }
    IPatientRepository Patients { get; }
    IPrescriptionRepository Prescriptions { get; }
    IBranchRepository Branches { get; }
    Task<int> CommitAsync();
}