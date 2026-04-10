using Landscaping_WebApplication_API_.Model.Landscaping;
using Landscaping_WebApplication_API_.Services.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Landscaping_WebApplication_API_.Controllers
{
    [Route("api/garden/[controller]")]
    [ApiController]
    public class GardenController : ControllerBase
    {
        private readonly IGardenService _service;

        public GardenController(IGardenService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Create(Garden garden)
        {
             var result=_service.Add(garden);
            return Ok(result);
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var result= _service.GetById(id);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll(int pageIndex=1, int pageSize=3)
        {
            var result=_service.GetAll(pageIndex, pageSize);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Garden garden)
        {
            garden.Id = id;
            var result= _service.Update(garden);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            var delete= _service.Delete(id);
            if (delete == true) return Ok("Deleted Successfully");
            else return Ok("Deletion failed");
        }
    }
}
