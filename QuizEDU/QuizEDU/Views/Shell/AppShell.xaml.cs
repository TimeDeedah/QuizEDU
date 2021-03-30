using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace QuizEDU.Views.Shell
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            BindingContext = new AppShellViewModel();
        }
    }
}
