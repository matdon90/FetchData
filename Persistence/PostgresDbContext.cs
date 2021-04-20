using Application.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class PostgresDbContext : DbContext, IPostgresDbContext
    {
        public PostgresDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<WorkRoll> WorkRolls { get; set; }
    }
}
