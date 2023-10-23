using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class PrescriptionInfoDto
    {
        public int Id { get; set; } = default!;
        public int PatientId { get; set; } = default!;
        public string PrescriptionText { get; set; } = default!;
        public int DoctorUserId { get; set; } = default!;
    }
}
