using System;

namespace Dragon.Tactics.Domain.Models
{
    [Flags]
    public enum EffectBaseType
    {
        [Obsolete] None = 0,

        Physical = 1 << 0,
        Magical  = 1 << 1,

        Any = -1
    }
}