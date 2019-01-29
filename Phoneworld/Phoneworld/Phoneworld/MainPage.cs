using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Core
{
    class MainPage : ContentPage {
        public MainPage(){
            Content = new StackLayout {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    new Label {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "Welcome to Xamarin.Forms!"
                    }
                }
            };
        }
    }
}
