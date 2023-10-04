using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackApp.Model
{
    public class EmployeeContext: DbContext
    {

        //1=>Dependency Injection - Initializing base class DbContext from Child class using DI
        public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options)
        {

        }

        //2=>Defining All the Entity Classes present in Model Folder
        public DbSet<TblEmployee> Employee { get; set; }
        public DbSet<TblDesignation> Designation { get; set; }
    }
}
