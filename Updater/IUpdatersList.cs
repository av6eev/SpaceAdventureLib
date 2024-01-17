namespace Updater
{
    public interface IUpdatersList : IUpdater
    {
        void Add(IUpdater updater);
        void Remove(IUpdater updater);
        void Clear();
    }
}