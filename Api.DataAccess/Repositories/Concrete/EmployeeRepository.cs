﻿using Api.DataAccess.Context;
using Api.DataAccess.Repositories.Abstract;
using Api.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.DataAccess.Repositories.Concrete
{
    public class EmployeeRepository : IEmployeeRepository
    {//bir sınıfın içerisinde crud işlemleri için context sınıfım lazım. bunu di ile almam lazım
        private readonly ProjectContext _context;

        public EmployeeRepository(ProjectContext context)
        {
            _context = context;
        }

        public Employee CreateEmployee(Employee employee)
        {
            _context.Employees.Add(employee);//Employees dbset
            _context.SaveChanges();
            return employee;
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
            return _context.Employees.Find(id);
        }

        public int MaxId()
        {
            throw new NotImplementedException();
        }

        public Employee UpdateEmploye(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
