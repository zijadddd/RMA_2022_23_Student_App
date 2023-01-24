using RMA_2022_23_Student_App.Data;
using RMA_2022_23_Student_App.Models;

namespace RMA_2022_23_Student_App;

public partial class ClassPage : ContentPage
{
    private StudentSubjectRepository _studentSubjectRepository;
	public ClassPage(int subjectId)
	{
		InitializeComponent();

        BindingContext = this;

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
        StudentSubject studentSubject = _studentSubjectRepository.getStudentInfoAboutSubject(TabbeddPage.student.studentId, subjectId);
        presence.Text = "Presence: " + studentSubject.presence;
        seminarWork.Text = "Seminar work: " + studentSubject.seminarWork;
        firstPartialExam.Text = "First partial exam: " + studentSubject.firstPartialExam;
        secondPartialExam.Text = "Second partial exam: " + studentSubject.secondPartialExam;
        finalExam.Text = "Final exam: " + studentSubject.finalExam;
    }

    private async void ActivityPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new ActivityPage());
    }

    //protected override bool OnBackButtonPressed() { return false; }
}