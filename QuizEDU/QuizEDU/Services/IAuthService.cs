using System;
using System.Threading.Tasks;

namespace QuizEDU.Services
{
    public interface IAuthService
    {
        Task<bool> SignInWithEmail(string email, string password);
        bool SignOut();
        bool IsSignIn();
    }
}
