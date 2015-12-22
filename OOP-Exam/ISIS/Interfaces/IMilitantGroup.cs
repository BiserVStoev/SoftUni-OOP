using ISIS.Enums;

namespace ISIS.Interfaces
{
    public interface IMilitantGroup: IGroup, IAttack, IUpdateable
    {
        WarEffect WarEffect { get; }

        AttackType AttackType { get; }

        bool WarEffectHasTriggered { get; set; }
    }
}
