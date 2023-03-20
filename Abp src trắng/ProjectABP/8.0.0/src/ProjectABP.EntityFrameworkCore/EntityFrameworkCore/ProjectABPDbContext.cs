using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ProjectABP.Authorization.Roles;
using ProjectABP.Authorization.Users;
using ProjectABP.MultiTenancy;

namespace ProjectABP.EntityFrameworkCore
{
    public class ProjectABPDbContext : AbpZeroDbContext<Tenant, Role, User, ProjectABPDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ProjectABPDbContext(DbContextOptions<ProjectABPDbContext> options)
            : base(options)
        {
        }
    }
}
