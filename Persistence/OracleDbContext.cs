using Application.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class OracleDbContext : DbContext, IOracleDbContext
    {
        public OracleDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CushionSet> CushionsSets { get; set; }
    }
}
