using RMA_2022_23_Student_App.Data;
using RMA_2022_23_Student_App.Models;

namespace RMA_2022_23_Student_App;

public partial class Subjects : ContentPage
{
    private StudentSubjectRepository _studentSubjectRepository;
    public Subjects()
    {
        InitializeComponent();

        BindingContext = this;

        studentFullName.Text = TabbeddPage.student.firstName;
        studentProfilePhoto.Source = TabbeddPage.student.profilePhotoUrl;

        String temp = "";
        String[] dates = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        DateTimeOffset todayDate = DateTimeOffset.Now;
        temp += dates[todayDate.Month - 1] + " " + todayDate.Day;
        if (todayDate.Day % 10 == 1 && todayDate.Day != 11) temp += "st";
        else if (todayDate.Day % 10 == 2 && todayDate.Day != 12) temp += "nd";
        else if (todayDate.Day % 10 == 3 && todayDate.Day != 13) temp += "rd";
        else temp += "th";
        date.Text = temp;

        _studentSubjectRepository = new StudentSubjectRepository();
        listView.ItemsSource = _studentSubjectRepository.getAllStudentSubjects(TabbeddPage.student.studentId);
    }

    private async void OpenClassPage(object sender, EventArgs e)
    {
        Button b = sender as Button;
        var id = b.ClassId;
        await Navigation.PushModalAsync(new ClassPage(int.Parse(id)));
    } 
}