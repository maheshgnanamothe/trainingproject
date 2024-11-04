using Microsoft.EntityFrameworkCore;
using dotnet.Data.Entity;

namespace dotnet.Data.Context
{
    public class appdbcontext : DbContext
    {
        public appdbcontext(DbContextOptions options) : base(options)
        {
        
        }
        public DbSet<Users> Users { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }


    }
}
