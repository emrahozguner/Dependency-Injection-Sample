using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DISample.Interfaces;

namespace DISample.Factories
{
    public class ExceptionFactories
    {
        internal static ExceptionFactory GetExceptionFactory(IException e)
        {
            if (e is CoreLevelException)
                return new CoreLevelFactory();
            else if (e is UserLevelException)
                return new UserLevelFactory();
            else if (e is CriticalLevelException)
                return new CriticalLevelFactory();

            throw new NotSupportedException();
        }
    }
}
