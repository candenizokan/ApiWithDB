using Api.Business.Abstract;
using Api.Model.Models;
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

        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            var created = _service.CreateEmployee(employee);
            return Ok(employee);
        }

        //[HttpGet("{id}")]//localhost/api/employee/id

        [HttpGet]
        [Route("getWithid/{id}")]//localhost/api/employee/getWithid/id


        [HttpGet]
        [Route("[action]/{id}")]// localhost/api/employee/GetEmployeeById/id
        public IActionResult GetEmployeeById(int id)
        {
            var employee= _service.GetEmployee(id);
            if(employee!=null) return Ok(employee);
            return NotFound(); 
        }

        [HttpPut]
        [Route("PutEmployee")]
        public IActionResult Put([FromBody] Employee employee)
        {
            if (_service.GetEmployee(employee.ID) != null) return Ok(_service.UpdateEmploye(employee));
            return BadRequest();
            
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_service.GetEmployee(id) != null)
            {
                _service.DeleteEmployee(id);
                return Ok();
            }
            else return NotFound();
        }
    }
}
