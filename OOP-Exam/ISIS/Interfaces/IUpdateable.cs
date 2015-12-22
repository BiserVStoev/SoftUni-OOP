namespace ISIS.Interfaces
{
    public interface IUpdateable
    {
        void Update();

        bool HasUpdated { get; set; }
    }
}