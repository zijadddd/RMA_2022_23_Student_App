using System.Windows.Input;

namespace RMA_2022_23_Student_App;

public partial class MainPage : ContentPage
{

    public MainPage()
	{
		InitializeComponent();
        
        BindingContext = this;
    }

    private async void LoginClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Login());
    }

    private async void RegistrationClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new Registration());
    }
}

