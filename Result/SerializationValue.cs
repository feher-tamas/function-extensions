using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExtensions.Result
{
    internal struct SerializationValue<E>
    {
        public bool IsFailure { get; }
        public E Error { get; }

        internal SerializationValue(bool isFailure, E error)
        {
            IsFailure = isFailure;
            Error = error;
        }
    }
}
