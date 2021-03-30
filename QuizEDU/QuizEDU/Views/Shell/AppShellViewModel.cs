using System;
using System.Windows.Input;
using QuizEDU.Services;
using QuizEDU.ViewModels;
using Xamarin.Forms;

namespace QuizEDU.Views.Shell
{
    public class AppShellViewModel : BaseViewModel
    {
        public AppShellViewModel()
            {
                SignOutCommand = new Command(OnSignOut);
            }

            private void OnSignOut()
            {
                var authService = DependencyService.Resolve<IAuthService>();
                authService.SignOut();

                Xamarin.Forms.Shell.Current.GoToAsync("//SignInPage");
            }

        public ICommand SignOutCommand { get; }
    }   
}
