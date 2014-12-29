using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS.FunctionalTests.TestCore.TestSystem
{
    public static class WebDriverCache
    {
        private static WebDriverWrapper webDriver;

        public static WebDriverWrapper WebDriver
        {
            get
            {
                if(webDriver == null)
                    throw new Exception("Сначала вызови инициализацию");
                return webDriver;
            }
        }
    }
}
