using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISample.Interfaces
{
    public interface IPublisher
    {
        void Publish(IException exception);
    }
}
