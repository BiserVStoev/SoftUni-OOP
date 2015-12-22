namespace ISIS.Interfaces
{
    public interface IGroup
    {
        string Name { get; }

        int InitialHealth { get; }

        int Health { get; set; }

        int Damage { get; set; }

        bool IsAlive { get; set; }
    }
}
