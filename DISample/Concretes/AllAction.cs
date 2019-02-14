using DISample.Interfaces;

namespace DISample.Concretes
{
    internal class AllAction : IAction
    {
        public void Run(IException e, PublisherList publishers)
        {
            foreach (IPublisher p in publishers)
            {
                try
                {
                    p.Publish(e);
                }
                catch
                {

                }
            }
        }
    }
}