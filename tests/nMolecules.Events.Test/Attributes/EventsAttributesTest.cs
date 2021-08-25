using System;
using Xunit;
using NFluent;

namespace NMolecules.Events.Test
{
    [DomainEvent]
    class AccountOpened
    {
    }

    [DomainEventPublisher]
    class MoneyTransferredPublisher
    {
        [DomainEvent]
        event MoneyTransferredHandler MoneyTransferred;
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
