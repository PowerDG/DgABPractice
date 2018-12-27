using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RQCore.Roles.Dto;
using RQCore.Users.Dto;

namespace RQCore.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
