using Landscaping_WebApplication_API_.Model.Landscaping;
using Landscaping_WebApplication_API_.Services.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Landscaping_WebApplication_API_.Controllers
{
    [Route("api/Customer/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            _service=service;
        }


        [HttpPost]
        public IActionResult Create (Customer customer)
        {
            var created =_service.Add(customer);
            return Ok(created);
        }

        [HttpGet("{id}")]

        public IActionResult GetById(int id)
        {
            var customer=_service.GetById(id);
            return Ok(customer);
        }

        [HttpGet]
        public IActionResult GetAll(int pageIndex=1,int pageSize=3)
        {
            var result=_service.GetAll(pageIndex,pageSize);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id,Customer customer)
        {
            customer.Id = id;
            var result=_service.Update(customer);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            var delete = _service.Delete(id);
            return Ok(delete);
        }

    }
}
