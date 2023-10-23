using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class PatientRepository : Repository<Patient, int>, IPatientRepository
    {
        public PatientRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }

        public virtual async Task<IList<Patient>> GetAllPatientAsync(Expression<Func<Patient, bool>>? filter = null)
        {
            return filter == null
                ? await PostgresContext.Set<Patient>().ToListAsync()
                : await PostgresContext.Set<Patient>().Where(filter).ToListAsync();
        }

        public async Task<IList<Patient>> GetPatientByIdAsync(int id)
        {
            var patient = await PostgresContext.Set<Patient>()
                .Where(p => p.Id == id)
                .ToListAsync();

            return patient;
        }
    }
}
