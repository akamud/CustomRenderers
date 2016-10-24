using System;
using CustomRenderers;
using CustomRenderers.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyCustomButton), typeof(MyCustomButtonRenderer))]
namespace CustomRenderers.iOS
{
    public class MyCustomButtonRenderer : ViewRenderer<MyCustomButton, UIButton>
    {
        public MyCustomButtonRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<MyCustomButton> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                var uiButton = new UIButton(UIButtonType.RoundedRect);
                uiButton.SetTitle("Botão Custom Renderer", UIControlState.Normal);
                SetNativeControl(uiButton);
            }

            if (e.OldElement != null)
            {
                Control.TouchUpInside -= Control_TouchUpInside;
            }

            if (e.NewElement != null)
            {
                Control.TouchUpInside += Control_TouchUpInside;
            }
        }

        void Control_TouchUpInside(object sender, EventArgs e)
        {
            ((IClickable)Element)?.Click();
        }
    }
}
