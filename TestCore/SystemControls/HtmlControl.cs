using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMS.FunctionalTests.TestCore.TestSystem;
using OpenQA.Selenium;

namespace FMS.FunctionalTests.TestCore.SystemControls
{
    public abstract class HtmlControl
    {
        private readonly By locator;
        private readonly ISearchContext searchContext;
        private readonly string controlDescription;
        public readonly WebElementWrapper element;

        protected HtmlControl(string idLocator, HtmlControl container = null)
            : this(By.Id(idLocator), container)
        {
        }

        protected HtmlControl(By locator, HtmlControl container = null)
        {
            this.locator = locator;
            controlDescription = FormatControlDescription(locator.ToString(), container);
            searchContext = container != null ? container.element : WebDriverCache.WebDriver.GetSearchContext();
        }

        private string FormatControlDescription(string locatorString, HtmlControl container)
        {
            string description = string.Format("{0} ({1})", GetType().Name, locatorString);
            if (container == null)
                return description;

            return string.Format("{0} в контексте элемента {1}", description, container.controlDescription);
        }

        protected string FormatWithLocator(string message)
        {
            return string.Format("{0} '{1}'", message, controlDescription);
        }

        public string GetAttributeValue(string attributeName)
        {
            return element.GetAttribute(attributeName);
        }

        public bool HasClass(string className)
        {
            string actualClasses;
            return HasClass(className, out actualClasses);
        }

        private bool HasClass(string className, out string actualClasses)
        {
            actualClasses = GetAttributeValue("class");
            string[] actualClassesArray = actualClasses.Split(new[] { " ", "\r", "\n", "\t" },
                StringSplitOptions.RemoveEmptyEntries);
            string[] expectedClassesArray = className.Split(new[] { " ", "\r", "\n", "\t" },
                StringSplitOptions.RemoveEmptyEntries);
            return expectedClassesArray.All(actualClassesArray.Contains);
        }
    }
}
