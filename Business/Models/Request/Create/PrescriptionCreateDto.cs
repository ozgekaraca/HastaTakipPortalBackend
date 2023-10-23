using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class PrescriptionCreateDto
    {
        public int PatientId { get; set; } = default!;
        public string PrescriptionText { get; set; } = default!;
        public int DoctorUserId { get; set; } = default!;
    }
}
