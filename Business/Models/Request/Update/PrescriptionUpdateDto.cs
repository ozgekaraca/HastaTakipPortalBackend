using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class PrescriptionUpdateDto
    {
        public int PatientId { get; set; } = default!;
        public string PrescriptionText { get; set; } = default!;
        public int DoctorId { get; set; } = default!;
    }
}
