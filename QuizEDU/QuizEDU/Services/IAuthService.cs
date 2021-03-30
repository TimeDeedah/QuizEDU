using System;
using System.Threading.Tasks;

namespace QuizEDU.Services
{
    public interface IAuthService
    {
        bool IsSignIn();
        Task<bool> CreateUser(string email, string password);
        void SignOut();
        Task<string> SignIn(string email, string password);
    }
}
