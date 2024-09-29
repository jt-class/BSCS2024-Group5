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
            Routing.RegisterRoute(nameof(AccInfo), typeof(AccInfo));
            Routing.RegisterRoute(nameof(Home), typeof(Home));
            Routing.RegisterRoute(nameof(SearchBuddy), typeof(SearchBuddy));
            Routing.RegisterRoute(nameof(UserProfile), typeof(UserProfile));
            Routing.RegisterRoute(nameof(UserEditProfile), typeof(UserEditProfile));

        }


    }
}
