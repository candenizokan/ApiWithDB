using Api.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.DataAccess.Context
{
    public class ProjectContext : DbContext
    {

        //connection string
        //tabloların
        //konfigurasyonları dbcontextte yapıyorum



        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {

        }

        public DbSet<Employee> MyProperty { get; set; }



    }
}
