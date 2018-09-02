using System.Collections.Generic;

namespace Dragon.Tactics.Domain.Models
{
    public class Stats
    {
        public int MaxHealth { get; set; }
        public int MaxAbilityPoints { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Dexterity { get; set; } // accuracy
        public int Evasion { get; set; }
        public int Wisdom { get; set; } // matk
        public int Toughness { get; set; } // pdef
        public int Fortitude { get; set; } // mdef

        public IDictionary<Ailment, short> AilmentResist { get; set; } // defaults to 0 each

        public short TurnModifier { get; set; } // rarely used.  may be -5 to let the unit get its turns quicker.
    }
}