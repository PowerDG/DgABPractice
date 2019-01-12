using System.Threading.Tasks;
using Abp.Application.Services;
using DgCorER.Sessions.Dto;

namespace DgCorER.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
