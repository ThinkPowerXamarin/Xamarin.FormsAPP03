using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Widget;

[assembly: Xamarin.Forms.ExportRenderer(typeof(App1.CustomVisualElement.MyEntry), typeof(App1.Droid.CustomVisualElementRenderer.MyEntryRenderer))]

namespace App1.Droid.CustomVisualElementRenderer
{
    public class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                var nativeControl = (EditText)Control;
                nativeControl.Background = null;
            }
        }
    }
}