using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using SampleX.Core.ViewModels;
using UIKit;

namespace SampleX.iOS
{
	public partial class SecondView : MvxViewController
	{
		public SecondView() : base("SecondView", null)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var set = this.CreateBindingSet<SecondView, SecondViewModel>();
			set.Bind(MyLabel).To(vm => vm.Hello);
			set.Apply();

			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}


