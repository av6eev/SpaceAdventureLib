using System;

namespace Reactive.Field
{
    public class ReactiveField<T> : IReactiveField<T>
    {
        public event Action<T, T> OnChanged;

        private T _value;
        public T Value
        {
            get => _value;
            set
            {
                var oldValue = _value;

                if ((oldValue == null || oldValue.Equals(value)) && (value == null || value.Equals(oldValue))) return;
                
                _value = value;
                OnChanged?.Invoke(_value, oldValue);
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
