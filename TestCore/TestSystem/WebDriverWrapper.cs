using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FMS.FunctionalTests.TestCore.TestSystem
{
    public class WebDriverWrapper
    {
        private readonly IWebDriver driver;

        public object ExecuteScript(string script, params object[] args)
        {
            return ((IJavaScriptExecutor) driver).ExecuteScript(script, args);
        }

        public ISearchContext GetSearchContext()
        {
            return driver;
        }
    }
}
