using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Prescription: Entity<int>
    {
        public int PatientId { get; set; } // Hangi hastaya ait olduğunu belirtir
        public string PrescriptionText { get; set; }
        public int DoctorUserId { get; set; } // reçete ile doktor arasındaki ilişkiyi gösteren doktorun ID'si
        public User DoctorUser { get; set; } // reçete ile doktor arasındaki ilişkiyi temsil eden User (Doctor) özelliği

    }
}
