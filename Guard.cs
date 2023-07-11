using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExtensions
{
    public class Guard
    {
        public static void Require(bool precondition, string exceptionMessage)
        {
            if (!precondition)
                throw new ArgumentException(exceptionMessage);
        }
    }
}
