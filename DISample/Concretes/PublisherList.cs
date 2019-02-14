using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DISample.Interfaces;

namespace DISample.Concretes
{
    public class PublisherList :List<IPublisher>
    {
        public void AddPublisher(IPublisher publisher)
        {
            this.Add(publisher);
        }
    }
}
