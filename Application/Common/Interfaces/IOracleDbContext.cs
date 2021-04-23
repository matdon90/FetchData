using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{
    public interface IOracleDbContext
    {
        DbSet<CushionSet> CushionsSets { get; set; }
    }
}
