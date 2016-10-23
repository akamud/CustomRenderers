using Android.Widget;
using CustomRenderers;
using CustomRenderers.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyCustomView), typeof(MyCustomViewRenderer))]
namespace CustomRenderers.Droid
{
    public class MyCustomViewRenderer : ViewRenderer<MyCustomView, TextView>
    {
        public MyCustomViewRenderer()
        {
            
        }

        protected override void OnElementChanged(ElementChangedEventArgs<MyCustomView> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                SetNativeControl(new TextView(Context)
                {
                    Text = "Oi Android"
                });
            }
        }
    }
}

