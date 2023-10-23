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
    public interface IBranchRepository : IRepository<Branch, int>
    {
        Task<IList<Branch>> GetAllBranchAsync(Expression<Func<Branch, bool>>? filter = null);

        Task<IList<Branch>> GetBranchByIdAsync(int id);
    }
}
