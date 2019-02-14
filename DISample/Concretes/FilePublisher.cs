using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DISample.Interfaces;

namespace DISample.Concretes
{
    public class FilePublisher :IPublisher
    {
        public void Publish(IException exception)
        {
            Console.WriteLine("File wrote");
        }
    }
}
