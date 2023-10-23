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
    public class BranchRepository : Repository<Branch, int>, IBranchRepository
    {
        public BranchRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }

        public virtual async Task<IList<Branch>> GetAllBranchAsync(Expression<Func<Branch, bool>>? filter = null)
        {
            return filter == null
                ? await PostgresContext.Set<Branch>().ToListAsync()
                : await PostgresContext.Set<Branch>().Where(filter).ToListAsync();
        }

        public async Task<IList<Branch>> GetBranchByIdAsync(int id)
        {
            var branch = await PostgresContext.Set<Branch>()
                .Where(p => p.Id == id)
                .ToListAsync();

            return branch;
        }
    }
}
