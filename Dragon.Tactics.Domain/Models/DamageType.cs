using System;

namespace Dragon.Tactics.Domain.Models
{
    [Flags]
    public enum DamageType
    {
        None    = 0,
        Slash   = 1 << 0,
        Pierce  = 1 << 1,
        Strike  = 1 << 2,
        Magic   = 1 << 3,
        Heal    = 1 << 4,
        Psionic = 1 << 5,

        Other   = 1 << 31,

        Any = -1
    }

    // Note:  considering a weapon triangle:  Slash > Strike > Pierce > Slash
    // TODO:  Should there be magic subtype triangle?  Elemental, Force, Arcane?  Kinda abstract, hard to pick out a triangle.
}
