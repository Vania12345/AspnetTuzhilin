 
using AspnetTuzhilin.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AspnetTuzhilin.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options) : base(options)
        {
           
        }
        public DbSet<Value> Values { get; set; } 
        
    }
}