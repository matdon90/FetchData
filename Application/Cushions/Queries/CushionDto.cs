using Domain.Enums;

namespace Application.Cushions.Queries
{
    public class CushionDto
    {
        public int StandNumber { get; set; }
        public RollPosition Position { get; set; }
        public string CushionSetNumber { get; set; }
    }
}
