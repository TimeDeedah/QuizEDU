using System;
using System.Threading.Tasks;
using QuizEDU.Services;
using Firebase;
using Android.Gms.Extensions;

namespace QuizEDU.Droid.Services
{
    public class AuthService : IAuthService
    {

       public bool IsSignIn()
        {
            var user = Firebase.Auth.FirebaseAuth.Instance.CurrentUser;
            var signedIn = user != null;
            return signedIn;
        }

        public async Task<bool> SignInWithEmail(string email, string password)
        {
            try
            {
                await Firebase.Auth.FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(email, password);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        bool IAuthService.SignOut()
        {
            try
            {
                Firebase.Auth.FirebaseAuth.Instance.SignOut();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
