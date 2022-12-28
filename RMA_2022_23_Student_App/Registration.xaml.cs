using System.Windows.Input;

namespace RMA_2022_23_Student_App;

public partial class Registration : ContentPage
{

    public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
    public Registration()
	{
		InitializeComponent();
        BindingContext = this;
    }
}