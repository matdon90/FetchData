using MediatR;

namespace Application.Cushions.Queries.SingleCushion
{
    public class SingleCushionQuery : IRequest<CushionDto>
    {
        public int Stand { get; set; }
        public int RollPosition { get; set; }

        public SingleCushionQuery()
        {

        }
        public SingleCushionQuery(int stand, int rollPosition)
        {
            this.Stand = stand;
            this.RollPosition = rollPosition;
        }
    }
}
