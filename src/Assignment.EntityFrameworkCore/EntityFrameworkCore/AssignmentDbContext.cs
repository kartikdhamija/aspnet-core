using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Assignment.Authorization.Roles;
using Assignment.Authorization.Users;
using Assignment.MultiTenancy;
using Assignment.Domain;
using System.Reflection;

namespace Assignment.EntityFrameworkCore
{
    public class AssignmentDbContext : AbpZeroDbContext<Tenant, Role, User, AssignmentDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Country> Countrys {get; set;}
        public AssignmentDbContext(DbContextOptions<AssignmentDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
