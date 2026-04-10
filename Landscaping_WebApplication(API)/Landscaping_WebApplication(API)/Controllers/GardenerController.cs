using Landscaping_WebApplication_API_.Model.Landscaping;
using Landscaping_WebApplication_API_.Services.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Landscaping_WebApplication_API_.Controllers
{
    [Route("api/gardener/[controller]")]
    [ApiController]
    public class GardenerController : ControllerBase
    {
        private readonly IGardenerService _service;

        public GardenerController(IGardenerService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Create(Gardener gardener)
        {
            var result = _service.Add(gardener);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result= _service.GetById(id);
            return Ok(result);
        }

        [HttpGet]

        public IActionResult GetAll(int pageIndex = 1, int pageSize = 10)
        {
            var result=_service.GetAll(pageIndex, pageSize);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Gardener gardener)
        {
            gardener.Id = id;
            var result=_service.Update(gardener);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result=_service.Delete(id);
            if (result == true) return Ok("Deleted Successfully");
            else return Ok("Deleteion failed");
        }
    }
}
