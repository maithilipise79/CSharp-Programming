using Landscaping_WebApplication_API_.Model.Landscaping;
using Landscaping_WebApplication_API_.Services.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Landscaping_WebApplication_API_.Controllers
{
    [Route("api/maintenance/[controller]")]
    [ApiController]
    public class MaintenanceTaskController : ControllerBase
    {

        private readonly IMaintenanceTaskService _service;

        public MaintenanceTaskController(IMaintenanceTaskService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Create(MaintenanceTask maintenanceTask)
        {
            var result = _service.Add(maintenanceTask);
            return Ok(result);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _service.GetById(id);
            return Ok(result);
        }

        [HttpGet]

        public IActionResult GetAll(int pageIndex = 1, int pageSize = 10)
        {
            var result = _service.GetAll(pageIndex, pageSize);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, MaintenanceTask maintenanceTask)
        {
            maintenanceTask.Id = id;
            var result = _service.Update(maintenanceTask);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _service.Delete(id);
            if (result == true) return Ok("Deleted Successfully");
            else return Ok("Deletion failed");
        }
    }
}
