using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Business.Abstract
{
    public interface IEmployeeService
    {

        List<Employee> GetAllEmployees();
    }
}
