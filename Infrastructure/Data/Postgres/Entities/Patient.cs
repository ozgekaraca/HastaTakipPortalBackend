using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Patient: Entity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public User DoctorUser { get; set; } // Hasta ile doktor arasındaki ilişkiyi temsil eden User (Doctor) özelliği
        public int DoctorUserId { get; set; } // Hasta ile doktor arasındaki ilişkiyi gösteren doktorun ID'si

    }
}
