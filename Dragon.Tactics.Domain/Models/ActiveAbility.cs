namespace Dragon.Tactics.Domain.Models
{
    public class ActiveAbility
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Cooldown { get; set; }

        // the following are the resultant Effect... maybe a new model?  
        public EffectBaseType EffectBase { get; set; }
        public DamageType DamageType { get; set; }
        public Element Element { get; set; }
        public int Range { get; set; } // how far away from self does the effect start? (0 = centered on self, 1 = one tile away, etc.)
        public int Length { get; set; } // how many tiles away from the effect start does the effect end?
        public int Width { get; set; } // how many tiles wide is the effect?
        public int Height { get; set; } // what is the vertical range of the effect?
        public EffectShape Shape { get; set; }
    }
}
