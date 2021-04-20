using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common
{
    public interface IPostgresDbContext
    {
        DbSet<WorkRoll> WorkRolls { get; set; }
    }
}
