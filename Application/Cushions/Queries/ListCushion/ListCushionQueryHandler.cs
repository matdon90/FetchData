using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Cushions.Queries.ListCushion
{
    public class ListCushionQueryHandler : IRequestHandler<ListCushionQuery, List<CushionDto>>
    {
        public Task<List<CushionDto>> Handle(ListCushionQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
