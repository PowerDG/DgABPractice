using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DgCorER.Roles.Dto;
using DgCorER.Users.Dto;

namespace DgCorER.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
