using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExtensions.Result
{
    public class ResultSuccessException : Exception
    {
        internal ResultSuccessException()
            : base(Result.Messages.ErrorIsInaccessibleForSuccess)
        {
        }
    }
}
