using MediatR;
using System.Collections.Generic;

namespace Application.Cushions.Queries.ListCushion
{
    public class ListCushionQuery : IRequest<List<CushionDto>>
    {
    }
}
