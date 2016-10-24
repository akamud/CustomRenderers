using System;
using Xamarin.Forms;

namespace CustomRenderers
{
    public class MyCustomButton : View, IClickable
    {
        public event EventHandler Clicked;

        public MyCustomButton()
        {
        }

        public void Click()
        {
            Clicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
