using System.Collections.Generic;

namespace Updater
{
    public class UpdatersList : IUpdatersList
    {
        private readonly List<IUpdater> _updaters = new();
        private readonly List<IUpdater> _toRemove = new();
        
        public void Update(float deltaTime)
        {
            foreach (var updater in _toRemove)
            {
                _updaters.Remove(updater);
            }
            
            _toRemove.Clear();
            
            foreach (var updater in _updaters)
            {
                updater.Update(deltaTime);
            }
        }

        public void Add(IUpdater updater)
        {
            _updaters.Add(updater);
        }

        public void Remove(IUpdater updater)
        {
            _toRemove.Add(updater);
        }

        public void Clear()
        {
            _updaters.Clear();
        }
    }
}