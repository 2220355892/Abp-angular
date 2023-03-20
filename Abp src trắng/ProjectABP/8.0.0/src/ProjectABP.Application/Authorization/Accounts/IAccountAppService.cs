using System.Threading.Tasks;
using Abp.Application.Services;
using ProjectABP.Authorization.Accounts.Dto;

namespace ProjectABP.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
