using AutoMapper;
using HealthcareAPI.DBModels;
using HealthcareAPI.RequestModels;

namespace HealthcareAPI.AutoMapper
{
    public class HealthcareAppAutoMapper: Profile
    {
        public HealthcareAppAutoMapper()
        {
            // AutoMapper configuration for mapping between UserDetails and UserDetailsRequest
            CreateMap<UserDetails, UserDetailsRequest>().ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));
            CreateMap<UserDetailsRequest, UserDetails>().ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));

            // AutoMapper configuration for mapping between UserRole and UserRole
            CreateMap<UserRole, UserRole>().ForAllMembers(opt => opt.Condition((src, dest, srcMember) => srcMember != null));
        }
    }
}
