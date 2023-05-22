namespace LoginAttempts;

public partial class MainPage : ContentPage
{
	string password = "welcome";
	int retryCount = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnClicked(object sender, EventArgs e)
	{
	 if(txtbxPassword.Text.ToLower().Equals(password))
		{
			lblStatus.Text = "Welcome !";
		}
	 else
		{
			retryCount++;
			if (retryCount >= 5)
			{
                lblStatus.Text = "You have been locked out.";
            }
			else
				lblStatus.Text = "Incorrect password.";


        }
	}
}

