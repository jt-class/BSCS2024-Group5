namespace SamePage.Views;

public partial class LogIn : ContentPage
{
	public LogIn()
	{
		InitializeComponent();
	}

    private void SignUpPortal(object sender, EventArgs e)
    {

        Shell.Current.GoToAsync(nameof(SignUp));

    }

    private void LoginMethod(object sender, EventArgs e)
    {

        Shell.Current.GoToAsync(nameof(SignUp));

    }


}