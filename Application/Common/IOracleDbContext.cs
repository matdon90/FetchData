using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common
{
    public interface IOracleDbContext
    {
        DbSet<CushionSet> CushionsSets { get; set; }
    }
}
