using Abp.Application.Services;
using ProjectABP.MultiTenancy.Dto;

namespace ProjectABP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

