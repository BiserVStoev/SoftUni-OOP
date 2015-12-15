using _02.Animals.Interfaces;

namespace _02.Animals.Models
{
    public abstract class Animal: ISoundProducible
    {
        protected Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public abstract string ProduceSound();

        public override string ToString()
        {
            return string.Format("My name is {0} and I am a {1} {2} old {3}. {4}", this.Name, this.Age, this.Age != 1 ? "years" : "year",
                this.GetType().Name, this.ProduceSound());
        }
    }
}
