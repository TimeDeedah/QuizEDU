using System;
using QuizEDU.Services;
using Xamarin.Forms;

namespace QuizEDU.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            CheckIsSignIn();
        }
        private async void CheckIsSignIn()
        {
            try
            {
                var authenticationService = DependencyService.Resolve<IAuthService>();
                if (!authenticationService.IsSignIn())
                    await Shell.Current.GoToAsync("//SignInPage");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
