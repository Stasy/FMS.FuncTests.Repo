using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FMS.FunctionalTests.TestCore.SystemControls
{
    public class Button : HtmlControl
    {
        public StaticText Caption { get; private set; }

        public Button(string idLocator, HtmlControl container = null) : base(idLocator, container)
        {
            Caption = new StaticText(idLocator + "_Caption", container);
        }

        public void WaitEnabled()
        {
            string description = FormatWithLocator("Ожидание доступности элемента");
            Assert.IsTrue(IsEnabled, description);
        }

        public virtual bool IsEnabled
        {
            get { return string.IsNullOrEmpty(GetAttributeValue("disabled")) && !HasClass("-disabled"); }
        }
    }
}
