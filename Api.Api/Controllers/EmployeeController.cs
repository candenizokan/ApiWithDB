using Api.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Api.Controllers
{
    [Route("api/[controller]")] // localhost/api/employee
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)//ben abstract isteyeceğim o concrete verecek
        {
            _service = service;
        }


        public IActionResult Get()
        {
            return Ok(_service.GetAllEmployees());
        }
    }
}
