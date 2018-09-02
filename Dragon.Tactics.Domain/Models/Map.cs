namespace Dragon.Tactics.Domain.Models
{
    public class Map // aggregate root
    {
        public long Id { get; set; }
        public Tile[][] Board { get; set; }
    }

    public class Tile // value object
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; } // height
    }
}
