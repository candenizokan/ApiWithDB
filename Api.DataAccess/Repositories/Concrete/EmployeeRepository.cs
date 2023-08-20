using Api.DataAccess.Repositories.Abstract;
using Api.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.DataAccess.Repositories.Concrete
{
    public class EmployeeRepository : IEmployeeRepository
    {
        //bir sınıfın içerisinde crud işlemleri için context sınıfım lazım. bunu di ile almam lazım




        public EmployeeRepository()
        {

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
