using System;
using System.Windows.Input;
using QuizEDU.Services;
using Xamarin.Forms;

namespace QuizEDU.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string email;
        private string password;

        public LoginViewModel()
        {
            SignUpCommand = new Command(OnSignUp);
            SignInCommand = new Command(OnSignIn);
            SignUpBtn = new Command(SignUp);

        }

        private async void SignUp()
        {
            try
            {
                var authService = DependencyService.Resolve<IAuthService>();
                if (await authService.CreateUser(Email, Password))
                {
                    await Shell.Current.GoToAsync("//HomePage"); 
                    await Shell.Current
                    .DisplayAlert("Create User", "Succes", "OK");
                }
                else
                {
                    Console.WriteLine("A problem occurs when creating a user");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                await Shell.Current
                    .DisplayAlert("Create Users", "An error occurs", "OK");
            }
        }

        private async void OnSignIn()
        {
            try
            {
                var authService = DependencyService.Resolve<IAuthService>();
                var token = await authService.SignIn(Email, Password);

                await Shell.Current.GoToAsync("//HomePage");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                await Shell.Current
                    .DisplayAlert("SignIn", "An error occurs", "OK");
            }
        }

        private async void OnSignUp()
        {
            await Shell.Current.GoToAsync("//SignUpPage");
        }
        #region Properties
        public string Password
        {
            get => password;
            set => SetProperty(ref password, value);
        }

        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }
        #endregion

        #region Commands

        public ICommand SignUpCommand { get; }
        public ICommand SignInCommand { get; }
        public ICommand SignUpBtn { get; }
        #endregion
    }
}
