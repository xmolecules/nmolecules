using Xunit;
using NFluent;

namespace NMolecules.Architecture.Layered.Test
{
    [ApplicationLayer]
    class TransferMoney
    {
    }

    [DomainLayer]
    class BankAccount
    {
    }

    public class LayerAttributesTest
    {
        [Fact]
        public void TestAttributes()
        {
            // Not really a unit test, more a compile test...
            Check.That(true).IsTrue();
        }
    }
}
