using System.Windows.Input;

namespace RMA_2022_23_Student_App;

public partial class MainPage : ContentPage
{

    public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

    public MainPage()
	{
		InitializeComponent();
        BindingContext = this;
    }
}

