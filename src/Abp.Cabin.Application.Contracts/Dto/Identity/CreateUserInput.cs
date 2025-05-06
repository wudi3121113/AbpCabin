using Volo.Abp.Identity;

namespace Abp.Cabin.Dto.Identity
{
    public class CreateUserInput : IdentityUserCreateDto
    {
        public string SiteCode { get; set; }
    }
}
