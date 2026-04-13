using Landscaping_WebApplication_API_.Model.Landscaping;
using Landscaping_WebApplication_API_.Services.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Landscaping_WebApplication_API_.Controllers
{
    [Route("api/plant/[controller]")]
    [ApiController]
    public class PlantController : ControllerBase
    {

        private readonly IPlantService _service;

        public PlantController(IPlantService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Create(Plant plant)
        {
            var result = _service.Add(plant);
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
        public IActionResult Update(int id,Plant plant)
        {
            plant.Id = id;
            var result = _service.Update(plant);
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
