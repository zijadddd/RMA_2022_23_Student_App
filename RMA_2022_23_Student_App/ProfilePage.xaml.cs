using Microsoft.Maui.Controls.Platform;
using RMA_2022_23_Student_App.Models;

namespace RMA_2022_23_Student_App;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();
		BindingContext = this;

        fullName.Text = TabbeddPage.student.firstName + " " + TabbeddPage.student.lastName;
        birthDate.Text = TabbeddPage.student.birthDate;
        location.Text = TabbeddPage.student.location;
        phoneNumber.Text = TabbeddPage.student.phoneNumber;
        email.Text = TabbeddPage.student.email;
        index.Text = TabbeddPage.student.index;
        university.Text = TabbeddPage.student.university;
        faculty.Text = TabbeddPage.student.faculty;
        department.Text = TabbeddPage.student.department;
        description.Text = TabbeddPage.student.description;
        profilePhotoUrl.Source = TabbeddPage.student.profilePhotoUrl;
    }

    private async void LogoutClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new Login();
    }

    protected override bool OnBackButtonPressed() { return true; }
}