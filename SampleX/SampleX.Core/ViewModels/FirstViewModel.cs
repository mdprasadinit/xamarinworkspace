using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace SampleX.Core.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {
        private string _hello = "Hello MvvmCross";
        public string Hello
        { 
            get { return _hello; }
            set { SetProperty (ref _hello, value); }
        }

		public ICommand GoCommand
		{
			get
			{
				return new MvxCommand(() => ShowViewModel<SecondViewModel>());
			}
		}
    }
}
