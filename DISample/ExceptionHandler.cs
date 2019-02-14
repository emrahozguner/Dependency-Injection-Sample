using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DISample.Concretes;
using DISample.Factories;
using DISample.Interfaces;

namespace DISample
{
    public class ExceptionHandler
    {
        public static void Handle(IException e)
        {
            ExceptionFactory factory = ExceptionFactories.GetExceptionFactory(e);
            PublisherList publishers = factory.CreatePublishers();
            IAction action = factory.CreateAction();
            action.Run(e, publishers);
        }
    }
}
