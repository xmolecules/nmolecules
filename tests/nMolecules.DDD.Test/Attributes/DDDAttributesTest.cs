using Xunit;
using NFluent;

namespace NMolecules.DDD
{
    [ValueObject]
    struct IBAN
    {
    }

    [Entity]
    class BankAccount
    {
        #pragma warning disable CS0169 // The field is never used
        [Identity]
        private readonly IBAN iban;
        #pragma warning restore CS0169
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
