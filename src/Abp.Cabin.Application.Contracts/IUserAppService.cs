using System;
using System.Threading.Tasks;
using Abp.Cabin.Dto.Identity;
using Volo.Abp.Application.Services;

namespace Abp.Cabin
{
    public interface IUserAppService : IApplicationService
    {
        Task TestCreateAsync(CreateUserInput input);

        Task<UserDto> TestGetAsync(Guid id);
    }
}
