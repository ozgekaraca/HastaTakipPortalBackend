using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class PrescriptionConfiguration: BaseConfiguration<Prescription, int>
    {
        public override void Configure(EntityTypeBuilder<Prescription> builder)
        {
            base.Configure(builder);

            builder.HasKey(p => p.Id);
            builder.Property(p => p.DoctorUserId).IsRequired();
            builder.Property(p => p.PatientId).IsRequired();
            builder.Property(p => p.PrescriptionText).IsRequired();

        }
    }
}
