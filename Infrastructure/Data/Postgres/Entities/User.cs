using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class User : Entity<int>
{
    public string Email { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string FullName { get; set; } = default!;
    public byte[] PasswordSalt { get; set; } = default!;
    public byte[] PasswordHash { get; set; } = default!;
    public UserType UserType { get; set; }
    public ICollection<Patient> DoctorPatients { get; set; } // Doktorun hastaları
    public ICollection<Prescription> DoctorPrescriptions { get; set; } // Doktorun reçeteleri

    public Branch Branch { get; set; } // Doktorun branşı

}

public enum UserType
{
    Admin,
    Doctor
}