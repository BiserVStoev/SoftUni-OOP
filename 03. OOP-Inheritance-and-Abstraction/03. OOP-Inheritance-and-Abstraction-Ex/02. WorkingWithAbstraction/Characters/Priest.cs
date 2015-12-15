using _02.WorkingWithAbstraction.Interfaces;

namespace _02.WorkingWithAbstraction.Characters
{
    public class Priest : Character, IHeal
    {
        public Priest() : base(125, 200, 100)
        {
        }

        public override void Attack(Character character)
        {
            this.Mana -= 100;
            character.Health -= this.Damage;
            this.Health += this.Damage / 10;
        }

        public void Heal(Character character)
        {
            this.Mana -= 100;
            character.Health += 150;
        }
    }
}
