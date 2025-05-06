using Abp.Cabin.Dto.Identity;
using AutoMapper;
using Volo.Abp.Identity;

namespace Abp.Cabin;

public class CabinApplicationAutoMapperProfile : Profile
{
    public CabinApplicationAutoMapperProfile()
    {
        CreateMap<IdentityUser, UserDto>()
            .MapExtraProperties();
    }
}
