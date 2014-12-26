using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FMS.FunctionalTests.TestCore.SystemControls
{
    public class StaticText : HtmlControl
    {
        public StaticText(By locator, HtmlControl container = null)
            : base(locator, container)
        {
        }

        public StaticText(string idLocator, HtmlControl container = null)
            : base(idLocator, container)
        {
        }
    }
}
