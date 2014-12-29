using NUnit.Framework;
using TestCore;

namespace FMS.FunctionalTests.TestCore
{
    public class AbstractFunctionalTestBase : CoreTestBase
    {
        [SetUp]
        public override void SetUp()
        {
            base.SetUp();
        }
    }
}
