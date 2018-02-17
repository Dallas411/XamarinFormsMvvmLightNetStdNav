using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;
using XfMvvmLnetStdNav.ViewModel;

namespace XfMvvmLnetStdNav
{
    public class Locator
    {
        public const string FirstPage = "FirstPage";
        public const string SecondPage = "SecondPage";
        public const string ThirdPage = "ThirdPage";

        public Locator()
        {
            // ViewModels
            SimpleIoc.Default.Register<FirstViewModel>();
            SimpleIoc.Default.Register<SecondViewModel>();
            SimpleIoc.Default.Register<ThirdViewModel>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public FirstViewModel Main
        {
            get
            {
                return SimpleIoc.Default.GetInstance<FirstViewModel>();
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public SecondViewModel Second
        {
            get
            {
                return SimpleIoc.Default.GetInstance<SecondViewModel>();
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public ThirdViewModel Third
        {
            get
            {
                return SimpleIoc.Default.GetInstance<ThirdViewModel>();
            }
        }
    }
}
