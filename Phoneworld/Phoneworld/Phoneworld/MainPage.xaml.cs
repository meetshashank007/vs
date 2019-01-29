using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Phoneworld
{
	public partial class MainPage : ContentPage
	{
        Entry phoneNumberText;
        Button translateButon;
        Button callButton;

        string translateNumber;

		public MainPage(){
            
            //InitializeComponent();

            this.Padding = new Thickness(20, 20, 20, 20);

            StackLayout panel = new StackLayout{
                Spacing = 15
            };

            panel.Children.Add(new Label{
                Text = "Enter a Phoneworld:",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            });

            panel.Children.Add(phoneNumberText = new Entry{
                Text = "1-855-XAMARIN"
            });

            panel.Children.Add(translateButon = new Button{
                Text = "Translate"
            });

            panel.Children.Add(callButton = new Button {
                Text = "Call",
                IsEnabled = false
            });

            translateButon.Clicked += OnTranslate;
            callButton.Clicked += OnCall;
            this.Content = panel;
		}

        async void OnCall(object sender, EventArgs e){
            if(await this.DisplayAlert("Dial a Number", "Would you like to call " + translateNumber + " ?", "Yes", "No")){
                var dialer = DependencyService.Get<IDialer>();
                if(dialer != null){
                    await dialer.DialAsync(translateNumber);
                }
            }
        }

        private void OnTranslate(object sender, EventArgs e){
            string enteredNumber = phoneNumberText.Text;
            translateNumber = Core.PhoneworldTranslator.ToNumber(enteredNumber);

            if (!string.IsNullOrEmpty(translateNumber)){
                callButton.IsEnabled = true;
                callButton.Text = "Call (" + translateNumber + ")";
            }
            else{
                callButton.IsEnabled = false;
                callButton.Text = "Call";
            }
        }
    }
}
