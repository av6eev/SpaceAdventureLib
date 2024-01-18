using System.Collections.Generic;

namespace Pulls
{
    public abstract class Pull<T> : IPull<T>
    {
        private readonly Queue<T> _elements = new();

        public void Init(int minPullCount)
        {
            for (var i = 0; i < minPullCount; i++)
            {
                _elements.Enqueue(CreateElement());
            }
        }

        public T Get()
        {
            if (_elements.Count == 0)
            {
                _elements.Enqueue(CreateElement());
            }

            var pullObject = _elements.Dequeue();
            
            ModifyGetObject(pullObject);
            
            return pullObject;
        }

        public void Put(T element)
        {
            ModifyPutObject(element);
            _elements.Enqueue(element);
        }

        public void Dispose()
        {
            for (var i = 0; i < _elements.Count; i++)
            {
                RemoveElement(_elements.Dequeue());
            }
        }

        protected abstract T CreateElement();
        protected abstract void ModifyPutObject(T element);
        protected abstract void ModifyGetObject(T element);
        protected abstract void RemoveElement(T element);
    }
}