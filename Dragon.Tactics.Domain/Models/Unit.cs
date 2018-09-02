namespace Dragon.Tactics.Domain.Models
{
    public class Unit // aggregate root
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Race Race { get; set; }
        public Gender Gender { get; set; }
        public Stats BaseStats { get; set; }
    }
}
