using ISIS.Enums;

namespace ISIS.Interfaces
{
    public interface IMilitantGroupFactory
    {
        IMilitantGroup CreateGroup(string name, int health, int damage, WarEffect warEffect, AttackType attackType);
    }
}
