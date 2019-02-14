using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISample.Interfaces
{
    public abstract class IException : Exception
    {
        public int ErrorCode { get; set; }
        public int LanguageCode { get; set; }

    }

    public class CoreLevelException : IException
    {

    }
    public class UserLevelException : IException
    {

    }

    public class CriticalLevelException : IException
    {

    }
}
