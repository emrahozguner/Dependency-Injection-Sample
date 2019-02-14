using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DISample.Interfaces;

namespace DISample.Concretes
{
    public class EventPublisher:IPublisher
    {
        public void Publish(IException exception)
        {
            Console.WriteLine("Event wrote");
        }
    }
}
