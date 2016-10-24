using System;
using CustomRenderers;
using CustomRenderers.Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using AButton = Android.Widget.Button;

[assembly: ExportRenderer(typeof(MyCustomButton), typeof(MyCustomButtonRenderer))]
namespace CustomRenderers.Android
{
    public class MyCustomButtonRenderer : ViewRenderer<MyCustomButton, AButton>
    {
        public MyCustomButtonRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<MyCustomButton> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                var androidButton = new AButton(Context);
                androidButton.Text = "Botão Custom Renderer";
                SetNativeControl(androidButton);
            }

            if (e.OldElement != null)
            {
                Control.Click -= Control_Click;
            }

            if (e.NewElement != null)
            {
                Control.Click += Control_Click;
            }
        }

        void Control_Click(object sender, EventArgs e)
        {
            ((IClickable)Element)?.Click();
        }
    }
}
