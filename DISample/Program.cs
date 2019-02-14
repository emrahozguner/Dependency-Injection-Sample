using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DISample.Interfaces;

namespace DISample
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionHandler.Handle(new CriticalLevelException());
            Console.ReadKey();
        }
    }
}
