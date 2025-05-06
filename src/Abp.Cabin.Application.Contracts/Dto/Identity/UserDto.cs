using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Data;

namespace Abp.Cabin.Dto.Identity
{
    public class UserDto : EntityDto<Guid>, IHasExtraProperties
    {
        public string? UserName { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? Email { get; set; }

        public bool IsActive { get; set; }

        public bool LockoutEnabled { get; set; }

        public string SiteCode { get; set; }

        public ExtraPropertyDictionary ExtraProperties { get; set; }
    }
}
