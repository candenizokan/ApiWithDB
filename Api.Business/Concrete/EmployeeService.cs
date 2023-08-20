using Api.Business.Abstract;
using Api.DataAccess.Repositories.Abstract;
using Api.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.Business.Concrete
{
    public class EmployeeService : IEmployeeService
    {//bazı kurallar dahilinde repoya iş yaptırmak istiyorum.///// soyut istiyorum somut ver diyorum. bunu startupta mutlaka söyleyeceğim
        private readonly IEmployeeRepository _repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        public Employee CreateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Employee UpdateEmploye(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
