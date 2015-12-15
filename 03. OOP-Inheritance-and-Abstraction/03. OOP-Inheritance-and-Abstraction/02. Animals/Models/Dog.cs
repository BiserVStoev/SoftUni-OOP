namespace _02.Animals.Models
{
    public class Dog: Animal
    {
        private const string DogSound = "Bau bau!";

        public Dog(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return DogSound;
        }
    }
}
