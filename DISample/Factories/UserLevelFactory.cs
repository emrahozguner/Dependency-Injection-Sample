using DISample.Concretes;
using DISample.Interfaces;

namespace DISample.Factories
{
    class UserLevelFactory : ExceptionFactory
    {
        internal override IAction CreateAction()
        {
            return new NoneAction();
        }

        internal override PublisherList CreatePublishers()
        {
            return new PublisherList();
        }
    }
}