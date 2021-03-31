using System.Threading.Tasks;
using Android.Gms.Extensions;
using Firebase.Auth;
using QuizEDU.Droid;
using QuizEDU.Services;

[assembly: Xamarin.Forms.Dependency(typeof(AndroidAuthService))]
namespace QuizEDU.Droid
{
    public class AndroidAuthService : IAuthService
    {
        public async Task<bool> CreateUser(string email, string password)
        {
            var authResult = await FirebaseAuth.Instance
                    .CreateUserWithEmailAndPasswordAsync(email, password);

            var userProfileChangeRequestBuilder = new UserProfileChangeRequest.Builder();
            userProfileChangeRequestBuilder.SetDisplayName(email);

            var userProfileChangeRequest = userProfileChangeRequestBuilder.Build();
            await authResult.User.UpdateProfileAsync(userProfileChangeRequest);

            return await Task.FromResult(true);
        }

        public bool IsSignIn()
            => FirebaseAuth.Instance.CurrentUser != null;


        public async Task<string> SignIn(string email, string password)
        {
            var authResult = await FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(email, password);
            var token = await authResult.User.GetIdToken(false).AsAsync<GetTokenResult>();
            return token.Token;
        }

        public void SignOut()
            => FirebaseAuth.Instance.SignOut();
    }
}

