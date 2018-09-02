using System;

namespace Dragon.Tactics.Domain.Models
{
    [Flags]
    public enum Ailment
    {
        Normal     = 0,
        Poisoned   = 1 << 0,
        Paralyzed  = 1 << 1,
        Petrified  = 1 << 2,
        Silenced   = 1 << 3,
        Slowed     = 1 << 4,
        Stopped    = 1 << 5,
        Frightened = 1 << 6,
        Berserk    = 1 << 7,
        Enraged    = 1 << 8,
        Befuddled  = 1 << 9,
        Charmed    = 1 << 10,
        
    }
}