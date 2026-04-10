using Landscaping_WebApplication_API_.Model;
using Landscaping_WebApplication_API_.Model.Landscaping;

namespace Landscaping_WebApplication_API_.Services.Implementation
{
    public interface IMaintenanceTaskService
    {
        MaintenanceTask Add(MaintenanceTask maintenanceTask); 
        MaintenanceTask Update(MaintenanceTask maintenanceTask);
        MaintenanceTask GetById(int id);
        PagedResult<MaintenanceTask> GetAll(int pageIndex, int pageSize);

        bool Delete(int id);
    }
}
