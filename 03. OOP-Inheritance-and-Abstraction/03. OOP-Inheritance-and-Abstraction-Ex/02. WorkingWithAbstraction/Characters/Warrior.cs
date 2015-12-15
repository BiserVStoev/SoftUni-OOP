namespace _02.WorkingWithAbstraction.Characters
{
    public class Warrior: Character
    {
        public Warrior() : base(300, 0, 120)
        {
        }

        public override void Attack(Character character)
        {
            character.Health -= this.Damage;
        }
    }
}
