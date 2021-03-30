using QuizEDU.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuizEDU.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
        }

    }
}