using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DgCorER.MultiTenancy.Dto;

namespace DgCorER.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

