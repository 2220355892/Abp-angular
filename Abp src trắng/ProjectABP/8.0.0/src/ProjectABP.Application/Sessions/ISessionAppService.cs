using System.Threading.Tasks;
using Abp.Application.Services;
using ProjectABP.Sessions.Dto;

namespace ProjectABP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
