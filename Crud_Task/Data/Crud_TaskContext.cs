using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Crud_Task.Models;

namespace Crud_Task.Data
{
    public class Crud_TaskContext : DbContext
    {
        public Crud_TaskContext (DbContextOptions<Crud_TaskContext> options)
            : base(options)
        {
        }

        public DbSet<Crud_Task.Models.Employee> Employees { get; set; }
    }
}
