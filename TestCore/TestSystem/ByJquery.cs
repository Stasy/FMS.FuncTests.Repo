using System.Runtime.InteropServices;
using OpenQA.Selenium;

namespace FMS.FunctionalTests.TestCore.TestSystem
{
    public class ByJquery : By
    {
        private readonly string jqueryLocator;

        public ByJquery(string jqueryLocator)
        {
            this.jqueryLocator = jqueryLocator;
        }

        public override IWebElement FindElement(ISearchContext context)
        {
            var scriptsToExecute = "return window." + jqueryLocator + "[0]";
            return (WebDriverCache.WebDriver.ExecuteScript(scriptsToExecute) as IWebElement);
        }
    }
}
