using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;

namespace Infrastructure.Data.Postgres.Repositories.Interface
{
    public interface IPrescriptionRepository: IRepository<Prescription, int>
    {
        Task<IList<Prescription>> GetAllPrescriptionAsync(Expression<Func<Prescription, bool>>? filter = null);

        Task<IList<Prescription>> GetPrescriptionByIdAsync(int id);
    }
}
