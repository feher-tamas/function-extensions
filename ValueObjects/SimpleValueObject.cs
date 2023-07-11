using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExtensions.ValueObjects
{
    [Serializable]
    public abstract class SimpleValueObject<T> : ValueObject
       where T : IComparable
    {
        public T Value { get; }

        protected SimpleValueObject(T value)
        {
            Value = value;
        }

        protected override IEnumerable<IComparable> GetEqualityComponents()
        {
            yield return Value;
        }

        public override string ToString()
        {
            return Value?.ToString();
        }

        public static implicit operator T(SimpleValueObject<T> valueObject)
        {
            return valueObject == null ? default : valueObject.Value;
        }
    }
}
