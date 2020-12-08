using Xunit;
using NFluent;

namespace NMolecules.DDD.Test
{
    [ValueObject]
    struct IBAN
    {
    }

    [Entity]
    class BankAccount
    {
        private readonly IBAN iban;
    }

    public class DDDAttributesTest
    {
        [Fact]
        public void TestAttributes()
        {
            // Not really a unit test, more a compile test...
            Check.That(true).IsTrue();
        }
    }
}
