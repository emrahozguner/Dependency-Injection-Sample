using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DISample.Concretes;
using DISample.Interfaces;

namespace DISample.Factories
{
    abstract class ExceptionFactory
    {
        internal abstract PublisherList CreatePublishers();
        internal abstract IAction CreateAction();
    }
}
