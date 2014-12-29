using System;

namespace FMS.FunctionalTests.TestCore.Pages.Timing
{
    public interface IPageTimeStatistics
    {
        T InvolveAction<T>(Type pageType, Func<T> func);

        void InvolveAction(Type pageType, Action func);
    }
}
