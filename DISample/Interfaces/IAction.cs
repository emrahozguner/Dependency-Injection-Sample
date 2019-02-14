using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DISample.Concretes;

namespace DISample.Interfaces
{
    internal interface IAction
    {
        void Run(IException e, PublisherList publishers);
    }
}
