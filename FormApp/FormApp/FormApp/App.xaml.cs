using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FormApp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            //The root page of the Application

            var layout = new StackLayout {
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    new Label{
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "Welcomt to Xamarin Form"
                    }
                }
            };

            //MainPage = new FormApp.MainPage();
            MainPage = new ContentPage {
                Content = layout
            };

            Button button = new Button{
                Text = "Click Me!"
            };

            button.Clicked += async (s, e) => {
                await MainPage.DisplayAlert("Alert", "Your Clicked Me!", "OK");
            };

            layout.Children.Add(button);
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
