using Microsoft.EntityFrameworkCore;
using MVC_Assignment2.Models;

namespace MVC_Assignment2.context
{
    public class EmpDBContext: DbContext
    {
        public EmpDBContext(DbContextOptions<EmpDBContext> options)
        : base(options) { }

        public DbSet<Employee> Emp{ get; set; }
       
    }
}
