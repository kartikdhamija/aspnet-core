using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Assignment.EntityFrameworkCore
{
    public static class AssignmentDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AssignmentDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AssignmentDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
