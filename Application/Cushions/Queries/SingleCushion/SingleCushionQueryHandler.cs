using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Cushions.Queries.SingleCushion
{
    public class SingleCushionQueryHandler : IRequestHandler<SingleCushionQuery, CushionDto>
    {
        private readonly IOracleDbContext _oracleDbContext;
        private readonly IPostgresDbContext _postgresDbContext;

        public SingleCushionQueryHandler(
            IOracleDbContext oracleDbContext,
            IPostgresDbContext postgresDbContext)
        {
            _oracleDbContext = oracleDbContext;
            _postgresDbContext = postgresDbContext;
        }

        public async Task<CushionDto> Handle(SingleCushionQuery request, CancellationToken cancellationToken)
        {
            var workRoll = await _postgresDbContext.WorkRolls
                .FirstOrDefaultAsync(w => w.StandNumber == request.Stand
                                          && w.Position == request.RollPosition);

            var cushionsSet = await _oracleDbContext.CushionsSets
                .FirstOrDefaultAsync(c => c.RollNumber == workRoll.RollNumber);

            return new CushionDto()
            {
                StandNumber = workRoll.StandNumber,
                Position = workRoll.Position,
                CushionSetNumber = cushionsSet.CushionSetNumber
            };
        }
    }
}
