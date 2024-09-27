using SamePage.Views;

namespace SamePage
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(LogIn), typeof(LogIn));
            Routing.RegisterRoute(nameof(SignUp), typeof(SignUp));

        }


    }
}
