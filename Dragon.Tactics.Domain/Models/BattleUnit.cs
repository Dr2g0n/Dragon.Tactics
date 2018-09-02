namespace Dragon.Tactics.Domain.Models
{
    public class BattleUnit // value object
    {
        public Unit Unit { get; set; }
        public Tile Position { get; set; }
        public Stats CurrentStats { get; set; } // ephemeral... maybe move to a BattleUnit container?
        public Ailment Status { get; set; }
    }
}
