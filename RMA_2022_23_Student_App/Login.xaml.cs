using System.Windows.Input;

namespace RMA_2022_23_Student_App;

public partial class Login : ContentPage
{

    public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

    public Login()
	{
		InitializeComponent();
	}

    private async void RegistrationClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Registration());
    }
}