using Microsoft.EntityFrameworkCore;
using DotNetCoreWebApi.Services.Common.Models;
using System.Reflection;

namespace DotNetCoreWebApi.Services.Common.Data 
{
    public class CommonDbContext : DbContext
    {
        public CommonDbContext(DbContextOptions<CommonDbContext> opt) : base(opt)
        {
            
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<UsaState> UsaStates { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}