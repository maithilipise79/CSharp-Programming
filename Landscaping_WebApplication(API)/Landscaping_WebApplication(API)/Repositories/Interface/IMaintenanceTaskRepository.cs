using Landscaping_WebApplication_API_.Model;
using Landscaping_WebApplication_API_.Model.Landscaping;

namespace Landscaping_WebApplication_API_.Repositories.Interface
{
    public interface IMaintenanceTaskRepository
    {
        MaintenanceTask Add(MaintenanceTask maintenance);
        MaintenanceTask GatById(int id);

        PagedResult<MaintenanceTask> GetAll(int pageIndex, int pageSize);

        MaintenanceTask Update(MaintenanceTask maintenance);

        bool Delete (int id);

    }
}
