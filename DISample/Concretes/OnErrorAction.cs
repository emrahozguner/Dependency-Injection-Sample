using DISample.Interfaces;

namespace DISample.Concretes
{
    internal class OnErrorAction : IAction
    {
        public void Run(IException e, PublisherList publishers)
        {
            foreach (IPublisher p in publishers)
            {
                try
                {
                    p.Publish(e);
                    return;
                }
                catch
                {

                }
            }
        }
    }
}