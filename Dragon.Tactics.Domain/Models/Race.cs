using System;

namespace Dragon.Tactics.Domain.Models
{
    [Flags]
    public enum Race
    {
        Any = -1,
        [Obsolete] None = 0,

        Human   = 1 << 0,
        Spirit  = 1 << 1,
        Machina = 1 << 2,
        Undead  = 1 << 3,
        Stone   = 1 << 4,
        Demon   = 1 << 5,
    }
}