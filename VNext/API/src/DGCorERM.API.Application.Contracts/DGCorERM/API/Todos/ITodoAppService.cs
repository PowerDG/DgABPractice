using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace DGCorERM.API.Todos
{
    public interface ITodoAppService
    {
        Task<PagedResultDto<TodoDto>> GetListAsync();
    }
}