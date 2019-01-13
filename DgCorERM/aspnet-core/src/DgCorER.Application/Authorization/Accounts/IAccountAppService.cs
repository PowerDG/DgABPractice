using System.Threading.Tasks;
using Abp.Application.Services;
using DgCorER.Authorization.Accounts.Dto;

namespace DgCorER.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
