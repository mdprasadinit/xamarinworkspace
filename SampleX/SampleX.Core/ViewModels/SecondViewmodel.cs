using MvvmCross.Core.ViewModels;

namespace SampleX.Core.ViewModels
{
    public class SecondViewModel 
        : MvxViewModel
    {
        private string _hello = "Hello 2nd Screen";
        public string Hello
        { 
            get { return _hello; }
            set { SetProperty (ref _hello, value); }
        }
    }
}
