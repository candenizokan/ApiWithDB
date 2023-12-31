﻿using Api.Business.Abstract;
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

        public EmployeeService(IEmployeeRepository repository)//constructor injektion
        {
            _repository = repository;
        }
        public Employee CreateEmployee(Employee employee)
        {
            if(employee != null) _repository.CreateEmployee(employee);
            return employee;
        }

        public void DeleteEmployee(int id)
        {
            if(id>0 && id<= _repository.MaxId()) _repository.DeleteEmployee(id);
        }

        public List<Employee> GetAllEmployees()
        {
            return _repository.GetAllEmployees(); 
        }

        public Employee GetEmployee(int id)
        {
            if (id > 0 && id <= _repository.MaxId()) return _repository.GetEmployee(id);
            throw new Exception("Silmek istediğiniz id'yi kontrol ediniz.");
        }

        public Employee UpdateEmploye(Employee employee)
        {
            if (employee != null) _repository.UpdateEmploye(employee);
            return employee ;
        }
    }
}
