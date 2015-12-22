using ISIS.Enums;
using ISIS.Interfaces;
using ISIS.Models;

namespace ISIS.Core.Factory
{
    public class GroupFactory: IMilitantGroupFactory
    {
        public IMilitantGroup CreateGroup(string name, int health, int damage, WarEffect warEffect, AttackType attackType)
        {
            return new MilitantGroup(name, health, damage, warEffect, attackType);
        }
    }
}
