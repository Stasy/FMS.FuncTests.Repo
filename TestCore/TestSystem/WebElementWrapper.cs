using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using TestCore;

namespace FMS.FunctionalTests.TestCore.TestSystem
{
    public class WebElementWrapper : IWebElement
    {
        private readonly ISearchContext searchContext;
        private readonly By locator;
        private readonly string description;
        private IWebElement nativeWebElement;

        public WebElementWrapper(ISearchContext searchContext, By locator, string description)
        {
            this.searchContext = searchContext;
            this.locator = locator;
            this.description = description;
        }

        public IWebElement FindElement(By by)
        {
            throw new NotSupportedException();
        }

        public ReadOnlyCollection<IWebElement> FindElements(By @by)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void SendKeys(string text)
        {
            throw new NotImplementedException();
        }

        public void Submit()
        {
            throw new NotImplementedException();
        }

        public void Click()
        {
            throw new NotImplementedException();
        }

        public string GetAttribute(string attributeName)
        {
            throw new NotImplementedException();
        }

        public string GetCssValue(string propertyName)
        {
            throw new NotImplementedException();
        }

        public string TagName { get; private set; }
        public string Text { get; private set; }
        public bool Enabled { get; private set; }
        public bool Selected { get; private set; }
        public Point Location { get; private set; }
        public Size Size { get; private set; }
        public bool Displayed { get; private set; }
    }
}
