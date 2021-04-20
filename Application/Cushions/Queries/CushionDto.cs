using Domain.Enums;

namespace Application.Cushions.Queries
{
    public class CushionDto
    {
        public int Stand { get; set; }
        public RollPosition Position { get; set; }
        public string CushionSetNumber { get; set; }
    }
}
