namespace SamePage.Views;

public partial class SignUp : ContentPage
{
	public SignUp()
	{
		InitializeComponent();
	}

    private void ToAccInfo(object sender, EventArgs e)
    {

        Shell.Current.GoToAsync(nameof(SignUp));

    }

}