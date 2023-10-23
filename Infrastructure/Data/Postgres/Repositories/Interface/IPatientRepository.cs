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
    public interface IPatientRepository: IRepository<Patient, int>
    {
        Task<IList<Patient>> GetAllPatientAsync(Expression<Func<Patient, bool>>? filter = null);

        Task<IList<Patient>> GetPatientByIdAsync(int id);
    }
}
