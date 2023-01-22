using System.Windows.Input;

namespace RMA_2022_23_Student_App;

public partial class Registration : ContentPage
{
    public Registration()
    {
        InitializeComponent();
        BindingContext = this;
    }

    private async void LoginClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Login());
    }
}