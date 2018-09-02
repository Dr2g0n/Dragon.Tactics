using System.Collections.Generic;

namespace Dragon.Tactics.Domain.Models
{
    public class Job
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public ICollection<ActiveAbility> Actives { get; set; } // TODO:  model out that abilities are unlocked at certain levels?
        public ICollection<Passive> Passives { get; set; }
        public ICollection<Reactive> Reactives { get; set; }
        public LeaderAbility LeaderAbility { get; set; }
    }
}
