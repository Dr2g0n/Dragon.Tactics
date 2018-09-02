namespace Dragon.Tactics.Domain.Models
{
    public class Reactive
    {
        public long Id { get; set; }
        public string Name { get; set; }

        // TODO need some method or properties to define what can trigger it (CanTriggerOnPhys, CanTriggerOnMag, RequiresNormalAttackReach)
        public EffectBaseType CanTriggerOnBaseType { get; set; } = EffectBaseType.Any;
        public DamageType CanTriggerOnDamageType { get; set; } = DamageType.Any;
        public bool RequiresNormalAttackReach { get; set; }
        public float TriggerChance { get; set; } = 100.00f; // invariant:  0.00 - 100.00


    }
}
