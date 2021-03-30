using System;
using QuizEDU.Services;
using QuizEDU.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuizEDU.Views.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {

        public SignUpPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
    }
}