using Domain.Enums;

namespace Domain.Entities
{
    public class WorkRoll
    {
        public int WorkRollId { get; set; }
        public int StandNumber { get; set; }
        public RollPosition Position { get; set; }
        public int RollNumber { get; set; }
    }
}
