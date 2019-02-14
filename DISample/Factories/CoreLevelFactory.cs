using DISample.Concretes;
using DISample.Interfaces;

namespace DISample.Factories
{
    class CoreLevelFactory : ExceptionFactory
    {
        internal override IAction CreateAction()
        {
            AllAction a1 = new AllAction();

            return a1;
        }

        internal override PublisherList CreatePublishers()
        {
            PublisherList publishers = new PublisherList();
            publishers.AddPublisher(new SqlPublisher());
            publishers.AddPublisher(new FilePublisher());
            publishers.AddPublisher(new SmsPublisher());

            return publishers;
        }
    }
}