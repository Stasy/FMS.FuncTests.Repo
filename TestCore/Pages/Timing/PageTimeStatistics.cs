using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMS.FunctionalTests.TestCore.Pages.Timing
{
    public class PageTimeStatistics : IPageTimeStatistics
    {
        public T InvolveAction<T>(Type pageType, Func<T> func)
        {
            throw new NotImplementedException();
        }

        public void InvolveAction(Type pageType, Action func)
        {
            throw new NotImplementedException();
        }
    }
}
