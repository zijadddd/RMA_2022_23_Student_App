using Microsoft.Maui.Controls.Platform;
using RMA_2022_23_Student_App.Models;

namespace RMA_2022_23_Student_App;

public partial class ProfilePage : ContentPage
{

	public ProfilePage()
	{
		InitializeComponent();
	}

	public ProfilePage(Student student)
	{
		InitializeComponent();
		BindingContext = this;

        fullName.Text = student.firstName + " " + student.lastName;
        birthDate.Text = student.birthDate;
        location.Text = student.location;
        phoneNumber.Text = student.phoneNumber;
        email.Text = student.email;
        index.Text = student.index;
        university.Text = student.university;
        faculty.Text = student.faculty;
        department.Text = student.department;
        description.Text = student.description;
        profilePhotoUrl.Source = student.profilePhotoUrl;
    }

    protected override bool OnBackButtonPressed() { return true; }
}