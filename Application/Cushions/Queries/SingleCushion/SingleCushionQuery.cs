using Domain.Enums;
using MediatR;

namespace Application.Cushions.Queries.SingleCushion
{
    public class SingleCushionQuery : IRequest<CushionDto>
    {
        public int Stand { get; set; }
        public RollPosition RollPosition { get; set; }

        public SingleCushionQuery()
        {

        }
        public SingleCushionQuery(int stand, RollPosition rollPosition)
        {
            this.Stand = stand;
            this.RollPosition = rollPosition;
        }
    }
}
