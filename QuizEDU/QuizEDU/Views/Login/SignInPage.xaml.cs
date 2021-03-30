using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizEDU.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuizEDU.Views.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
            this.BindingContext = new SignInViewModel();
        }
    }
}