using Application.Common;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Cushions.Queries.ListCushion
{
    public class ListCushionQueryHandler : IRequestHandler<ListCushionQuery, List<CushionDto>>
    {
        private readonly IOracleDbContext _oracleDbContext;
        private readonly IPostgresDbContext _postgresDbContext;

        public ListCushionQueryHandler(
            IOracleDbContext oracleDbContext,
            IPostgresDbContext postgresDbContext)
        {
            _oracleDbContext = oracleDbContext;
            _postgresDbContext = postgresDbContext;
        }
        public async Task<List<CushionDto>> Handle(ListCushionQuery request, CancellationToken cancellationToken)
        {
            var cushionsSets = await _oracleDbContext.CushionsSets.ToListAsync();
            var workRolls = await _postgresDbContext.WorkRolls.ToListAsync();

            var cushionsDtoList = new List<CushionDto>();

            foreach (var workRoll in workRolls)
            {
                cushionsDtoList.Add(new CushionDto
                {
                    StandNumber = workRoll.StandNumber,
                    Position = workRoll.Position,
                    CushionSetNumber = cushionsSets.Find(c => c.RollNumber == workRoll.RollNumber).CushionSetNumber
                });
            }

            return cushionsDtoList;
        }
    }
}
