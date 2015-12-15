namespace _02.WorkingWithAbstraction.Characters
{
    public class Mage : Character
    {
        public Mage() : base(100, 300, 75)
        {
        }

        public override void Attack(Character character)
        {
            this.Mana -= 100;
            character.Health -= this.Damage * 2;
        }
    }
}
