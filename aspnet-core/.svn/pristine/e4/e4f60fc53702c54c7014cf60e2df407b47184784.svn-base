using System.Threading.Tasks;
using Abp.Application.Services;
using RQCore.Authorization.Accounts.Dto;

namespace RQCore.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
