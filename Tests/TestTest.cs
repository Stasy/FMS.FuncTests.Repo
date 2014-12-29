using System.Runtime.InteropServices;
using FMS.FunctionalTests.TestCore.Pages;
using FMS.FunctionalTests.TestCore.SystemControls;
using NUnit.Framework;

namespace FMS.FunctionalTests.Tests
{
    public class TestTest
    {
        [Test]
        public void TestTest1()
        {
            
            button = new Button("еее!");
            button.WaitEnabled();
        }

        private Button button { get; set; }
        private PageBase pageBase;
    }
}
