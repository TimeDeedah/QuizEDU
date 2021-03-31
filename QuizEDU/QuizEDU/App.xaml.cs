
using QuizEDU.Views.Login;
using QuizEDU.Views.Shell;
using Xamarin.Forms;

namespace QuizEDU
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
