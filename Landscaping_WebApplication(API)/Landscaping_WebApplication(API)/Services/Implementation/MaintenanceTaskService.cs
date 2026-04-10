using Landscaping_WebApplication_API_.Model;
using Landscaping_WebApplication_API_.Model.Landscaping;
using Landscaping_WebApplication_API_.Repositories.Interface;

namespace Landscaping_WebApplication_API_.Services.Implementation
{
    public class MaintenanceTaskService : IMaintenanceTaskService
    {
        private readonly IMaintenanceTaskRepository _repository;

        public MaintenanceTaskService(IMaintenanceTaskRepository repository)
        {
            _repository = repository;
        }


        public MaintenanceTask Add(MaintenanceTask maintenanceTask)
        {
            if(maintenanceTask == null) throw new ArgumentNullException(nameof(maintenanceTask));

            if(string.IsNullOrWhiteSpace(maintenanceTask.TaskName))
            {
                throw new Exception("Task name id required");
            }
            if(maintenanceTask.NoOfWorkers<=0)
            {
                throw new Exception(" Invalid Number of Workers");
            }

            return _repository.Add(maintenanceTask);
        }

        public bool Delete(int id)
        {
            if(id <= 0)
            {
                throw new Exception("Invalid Id");
            }
            var record= _repository.GatById(id);
            if(record == null)
            {
                throw new Exception("Record Not Found");
            }
            return _repository.Delete(id);
        }


        public PagedResult<MaintenanceTask> GetAll(int pageIndex, int pageSize)
        {
            if(pageSize>15)
            {
                pageSize=15;
            }
            return _repository.GetAll(pageIndex, pageSize);
        }


        public MaintenanceTask GetById(int id)
        {
            if(id<=0)
            {
                throw new Exception("Invalid Id");
            }

            var record = _repository.GatById(id);
            if( record == null)
            {
                throw new Exception("Record Not Found");
            }
            return record;
        }

        public MaintenanceTask Update(MaintenanceTask maintenanceTask)
        {
            if(maintenanceTask.Id<=0)
            {
                throw new Exception("Invalid Id");
            }
            var existing=_repository.GatById(maintenanceTask.Id);

            if(existing == null)
            {
                throw new Exception("Record Not found");
            }

            if(string.IsNullOrWhiteSpace(maintenanceTask.TaskName))
            {
                throw new Exception(" Task Name is Required");
            }
            if(maintenanceTask.NoOfWorkers<0)
            {
                throw new Exception("Invalid Number of workers");
            }

            return _repository.Update(maintenanceTask);
        }
    }
}
