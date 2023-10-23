using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class PatientUpdateDto
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public int Age { get; set; } = default!;

        public int DoctorId { get; set; } = default!;

        public int SecretaryId { get; set; } = default!;
    }
}
