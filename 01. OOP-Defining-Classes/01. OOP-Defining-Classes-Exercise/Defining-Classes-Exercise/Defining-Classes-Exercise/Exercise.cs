using Defining_Classes_Exercise;

class Exercise
{
    static void Main()
    {
        Dog unnamed = new Dog();

        Dog sharo = new Dog("Sharo", "Melez");

        unnamed.Breed = "German Shepherd";

        unnamed.Bark();
        sharo.Bark();
    }
}
