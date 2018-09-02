using System;

namespace Dragon.Tactics.Domain.Models
{
    [Flags]
    public enum DamageType
    {
        None   = 0,
        Slash  = 1 << 0,
        Pierce = 1 << 1,
        Strike = 1 << 2,
        Magic  = 1 << 3,
        Heal   = 1 << 4,

        Other  = 1 << 31,

        Any = -1
    }
}
