using System;

using Xamarin.Forms;

namespace CustomRenderers
{
    public class MyCustomView : View
    {
        public static readonly Color[] XamarinSummitColors = new Color[] { 
            Color.FromHex("#EB1E53"), 
            Color.FromHex("#342389") 
        };

        public static readonly BindableProperty TextColorProperty = BindableProperty.Create(
            nameof(TextColor),
            typeof(Color),
            typeof(MyCustomView),
            Color.Black);

        public Color TextColor
        {
            get
            {
                return (Color)GetValue(TextColorProperty);
            }
            set
            {
                SetValue(TextColorProperty, value);
            }
        }

        public MyCustomView()
        {
        }
    }
}

