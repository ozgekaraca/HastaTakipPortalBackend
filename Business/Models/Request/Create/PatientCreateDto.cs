using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Models.Request.Create
{
    public class PatientCreateDto
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public int Age { get; set; } = default!;

        public int DoctorUserId { get; set; } = default!;

    }
}
