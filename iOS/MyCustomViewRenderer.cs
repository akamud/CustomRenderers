using System;
using CustomRenderers;
using CustomRenderers.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyCustomView), typeof(MyCustomViewRenderer))]
namespace CustomRenderers.iOS
{
    public class MyCustomViewRenderer : ViewRenderer<MyCustomView, UILabel>
    {
        public MyCustomViewRenderer()
        {
            
        }

        protected override void OnElementChanged(ElementChangedEventArgs<MyCustomView> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                SetNativeControl(new UILabel()
                {
                    Text = "Oi iOS",
                });
            }

            if (e.NewElement != null)
            {
                UpdateColor();
            }
        }

        void UpdateColor()
        {
            if (Element != null)
            {
                Control.TextColor = Element.TextColor.ToUIColor();
            }
        }
    }
}

