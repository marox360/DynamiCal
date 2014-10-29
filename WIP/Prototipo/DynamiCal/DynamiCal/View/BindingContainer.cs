using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamiCal.View
{
    interface IBindingContainer
    {
        string DisplayText { get; }

        object Value { get; }
    }

    class BindingContainer<T> : IBindingContainer, IEquatable<BindingContainer<T>>
    {
        public BindingContainer(T value) : this(value.ToString(), value) { }

        public BindingContainer(string text, T value)
        {
            this.DisplayText = text;
            this.Value = value;
        }

        public string DisplayText { get; set; }

        public T Value { get; set; }

        object IBindingContainer.Value
        {
            get
            {
                return this.Value;
            }
        }

        public bool Equals(BindingContainer<T> other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return EqualityComparer<T>.Default.Equals(this.Value, other.Value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            return Equals((BindingContainer<T>)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((this.Value != null ? this.Value.GetHashCode() : 0) * 397);
            }
        }
    }
}
