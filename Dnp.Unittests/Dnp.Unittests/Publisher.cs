namespace Dnp.Unittests;

public class Publisher(TimeProvider timeProvider) : IPublisher
{
    public void Publish(string message)
    {
        throw new NotImplementedException();
    }
}
