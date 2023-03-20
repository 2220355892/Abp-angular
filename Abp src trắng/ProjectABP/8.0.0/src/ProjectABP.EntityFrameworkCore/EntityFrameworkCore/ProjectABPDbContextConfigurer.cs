using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ProjectABP.EntityFrameworkCore
{
    public static class ProjectABPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ProjectABPDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ProjectABPDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
