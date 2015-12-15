namespace _02.Animals.Models
{
    public abstract class Cat: Animal
    {
        private const string CatSound = "Miauuu!";

        protected Cat(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return CatSound;
        }
    }
}
