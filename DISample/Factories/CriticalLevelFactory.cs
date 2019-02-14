using DISample.Concretes;
using DISample.Interfaces;

namespace DISample.Factories
{
    class CriticalLevelFactory : ExceptionFactory
    {
        internal override IAction CreateAction()
        {
            return new OnErrorAction();
        }

        internal override PublisherList CreatePublishers()
        {
            PublisherList publishers = new PublisherList();
            publishers.AddPublisher(new SqlPublisher());
            publishers.AddPublisher(new EventPublisher());

            return publishers;
        }
    }
}