using RMA_2022_23_Student_App.ViewModels;

namespace RMA_2022_23_Student_App;

public partial class IntroScreenView : ContentPage
{
	public IntroScreenView()
	{
		InitializeComponent();
        this.BindingContext = new IntroScreenViewModel();
    }
}