using Landscaping_WebApplication_API_.Model;
using Landscaping_WebApplication_API_.Model.Landscaping;
using Landscaping_WebApplication_API_.Repositories.Interface;

namespace Landscaping_WebApplication_API_.Repositories.Implementation
{
    public class MaintenanceTaskRepository : IMaintenanceTaskRepository
    {
        private readonly List<MaintenanceTask> _maintenance=new List<MaintenanceTask>();
        public MaintenanceTask Add(MaintenanceTask maintenance)
        {
            _maintenance.Add(maintenance);
            return maintenance;
        }

        public bool Delete(int id)
        {
            var result=_maintenance.FirstOrDefault(x => x.Id == id);
            if(result == null)return false;
            _maintenance.Remove(result);
            return true;
        }

        public MaintenanceTask GatById(int id)
        {
            return _maintenance.FirstOrDefault(y => y.Id == id);
        }

        public PagedResult<MaintenanceTask> GetAll(int pageIndex, int pageSize)
        {
            var totalCount=_maintenance.Count;
            var items=_maintenance.Skip((pageIndex-1)*pageSize).Take(pageSize).ToList();

            return new PagedResult<MaintenanceTask>
            {
                TotalCount = totalCount,
                Items = items,
                PageSize = pageSize,
                PageIndex = pageIndex

            };
        }

        public MaintenanceTask Update(MaintenanceTask maintenance)
        {
            var existing=_maintenance.FirstOrDefault(x=>x.Id==maintenance.Id);
            if (existing == null) return null;
            existing.TaskName = maintenance.TaskName;
            existing.Date = maintenance.Date;
            existing.NoOfWorkers = maintenance.NoOfWorkers;
            return maintenance;
        }
    }
}
