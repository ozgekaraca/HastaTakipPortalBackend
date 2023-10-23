using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Branch: Entity<int>
    {
        public string BranchName { get; set; }
        public ICollection<User> Doctors { get; set; } // Branşa ait doktorlar
    }
}
