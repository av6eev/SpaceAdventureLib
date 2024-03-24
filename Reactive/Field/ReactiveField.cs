using System;

namespace Reactive.Field
{
    public class ReactiveField<T> : IReactiveField<T>
    {
        public event Action<T> OnChanged;

        private T _value;
        public T Value
        {
            get => _value;
            set
            {
                if (_value.Equals(value)) return;
            
                _value = value;
                
                OnChanged?.Invoke(_value);
            }
        }

        public ReactiveField() : this(default)
        {
            _value = default;
        }

        public ReactiveField(T initialValue)
        {
            _value = initialValue;
        }
    }
}
