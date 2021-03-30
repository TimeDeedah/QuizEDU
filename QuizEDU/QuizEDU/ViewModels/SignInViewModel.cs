using System;
using System.Windows.Input;
using QuizEDU.Services;

namespace QuizEDU.ViewModels
{
    public class SignInViewModel : BaseViewModel
    {
        private ICommand signInCommand;

        private string _email;
        private string _password;

        private IAuthService authService;

        public SignInViewModel()
        {

        }
    }
}
