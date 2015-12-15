namespace _02.Animals.Models
{
    public class Frog: Animal
    {
        private const string FrogSound = "Wrebbit!";

        public Frog(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return FrogSound;
        }
    }
}
