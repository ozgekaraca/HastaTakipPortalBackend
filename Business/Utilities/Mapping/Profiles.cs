using Business.Models.Request.Create;
using Business.Models.Request.Functional;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        CreateMap<RegisterDto, User>().ReverseMap();
        CreateMap<User, UserProfileDto>().ReverseMap();
        CreateMap<UserUpdateDto, User>().ReverseMap();

        CreateMap<PatientCreateDto, Patient>().ReverseMap();
        CreateMap<PatientUpdateDto, Patient>().ReverseMap();
        CreateMap<Patient, PatientInfoDto>().ReverseMap();

        CreateMap<PrescriptionCreateDto, Prescription>().ReverseMap();
        CreateMap<PrescriptionUpdateDto, Prescription>().ReverseMap();
        CreateMap<Prescription, PrescriptionInfoDto>().ReverseMap();

        CreateMap<BranchCreateDto, Branch>().ReverseMap();
        CreateMap<BranchUpdateDto, Branch>().ReverseMap();
        CreateMap<Branch, BranchInfoDto>().ReverseMap();

    }
}