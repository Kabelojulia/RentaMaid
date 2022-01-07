using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace loginApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUI : ContentPage
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //if(txtUsername.Text==admin && txtPassword.Text == "123")
            // {

            //  }
            //else
            //{
            //DisplayAlert("Oops...""Username or password is incorrect!""OK);
            //}
            //Navigation.PushAsync(new Registration());
            Navigation.PushAsync(new Menu());

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            
          Navigation.PushAsync(new Registration());
      

        }
    }
    

}