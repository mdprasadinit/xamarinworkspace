using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace SampleX.Droid.Views
{
	[Activity(Label = "View for FirstViewModel", MainLauncher = true)]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }
}
