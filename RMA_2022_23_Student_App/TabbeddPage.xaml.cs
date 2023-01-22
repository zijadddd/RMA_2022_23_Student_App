using Microsoft.Maui.Controls;
using RMA_2022_23_Student_App.Models;

namespace RMA_2022_23_Student_App;

public partial class TabbeddPage : TabbedPage
{
    public TabbeddPage(Student student)
    {
        InitializeComponent();
        BindingContext = this;

        Children.Add(new ProfilePage(student));
        Children.Add(new Subjects(student));
        Children.Add(new SettingsPage());

        Children[0].Title = "";
        Children[1].Title = "";
        Children[2].Title = "";

        Children[0].IconImageSource = "profile.svg";
        Children[1].IconImageSource = "subject.svg";
        Children[2].IconImageSource = "settings.svg";
    }

    protected override bool OnBackButtonPressed() { return true; }
}