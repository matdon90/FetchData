using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{
    public interface IPostgresDbContext
    {
        DbSet<WorkRoll> WorkRolls { get; set; }
    }
}
