using System;

namespace _04.StudentClass
{
    class ProgramMain
    {
        public static void Main()
        {
            Student student = new Student("Peter", 22);
            student.OnPropertyChange += (sender, eventArgs) =>
            {
                Console.WriteLine("Property changed: {0} (from {1} to {2})",
                    eventArgs.PropName, eventArgs.PreviousData, eventArgs.NewData);
            };
            student.Name = "Maria";
            student.Age = 19;

        }
    }
}
