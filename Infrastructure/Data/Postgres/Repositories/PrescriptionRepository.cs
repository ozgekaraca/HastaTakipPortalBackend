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
    public class PrescriptionRepository : Repository<Prescription, int>, IPrescriptionRepository
    {
        public PrescriptionRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }

        public virtual async Task<IList<Prescription>> GetAllPrescriptionAsync(Expression<Func<Prescription, bool>>? filter = null)
        {
            return filter == null
                ? await PostgresContext.Set<Prescription>().ToListAsync()
                : await PostgresContext.Set<Prescription>().Where(filter).ToListAsync();
        }

        public async Task<IList<Prescription>> GetPrescriptionByIdAsync(int id)
        {
            var prescription = await PostgresContext.Set<Prescription>()
                .Where(p => p.Id == id)
                .ToListAsync();

            return prescription;
        }
    }
}
