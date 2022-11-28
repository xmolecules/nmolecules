using System;
using Xunit;
using NFluent;

namespace NMolecules.Events
{
    [DomainEvent]
    class AccountOpened
    {
    }

    [DomainEventPublisher]
    class MoneyTransferredPublisher
    {
        #pragma warning disable CS0067 // The event is never used
        [DomainEvent]
        event MoneyTransferredHandler MoneyTransferred;
        #pragma warning restore CS0067
    }

    [DomainEventHandler]
    delegate void MoneyTransferredHandler();

    public class EventsAttributesTest
    {
        [Fact]
        public void TestAttributes()
        {
            // Not really a unit test, more a compile test...
            Check.That(true).IsTrue();
        }
    }
}
