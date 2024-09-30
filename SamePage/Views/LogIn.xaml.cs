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

    private async void LoginMethod(object sender, EventArgs e)
    {

        
        if (string.IsNullOrWhiteSpace(Email.Text) || string.IsNullOrWhiteSpace(Password.Text))
        {
            
            await DisplayAlert("Invalid Input", "Please enter both email and password.", "OK");
        }
        else
        {
            
            await Shell.Current.GoToAsync(nameof(SignUp));
        }
    }


}