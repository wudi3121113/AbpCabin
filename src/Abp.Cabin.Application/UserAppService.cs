using System;
using System.Linq;
using System.Threading.Tasks;
using Abp.Cabin.Dto.Identity;
using Volo.Abp.Application.Services;
using Volo.Abp.Data;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;

namespace Abp.Cabin
{
    public class UserAppService(IReadOnlyRepository<IdentityUser, Guid> userRepository, IIdentityUserAppService identityUserAppService) : ApplicationService, IUserAppService
    {
        public virtual async Task TestCreateAsync(CreateUserInput input)
        {
            input.LockoutEnabled = true;
            
            input.SetProperty(nameof(input.SiteCode), input.SiteCode);

            await identityUserAppService.CreateAsync(input);
        }

        public virtual async Task<UserDto> TestGetAsync(Guid id)
        {
            var user = (await userRepository.WithDetailsAsync(u => u.Roles))
                .OrderByDescending(u => u.Id)
                .FirstOrDefault(u => u.Id == id)
                ?? throw new EntityNotFoundException(typeof(IdentityUser), id);

            return ObjectMapper.Map<IdentityUser, UserDto>(user);
        }
    }
}
