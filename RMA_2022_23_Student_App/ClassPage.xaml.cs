using DocuSign.eSign.Model;
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
        SubjectModel subject = _studentSubjectRepository.getInfoAboutSubject(subjectId);
        subjectName.Text = subject.name;
        numOfStudents.Text = _studentSubjectRepository.getNumberOfStudents(subjectId).ToString();
        presence.Text = "Presence: " + studentSubject.presence + "b";
        seminarWork.Text = "Seminar work: " + studentSubject.seminarWork + "b";
        homework.Text = "Homework: " + studentSubject.homework + "b";
        firstPartialExam.Text = "First partial exam: " + studentSubject.firstPartialExam + "b";
        secondPartialExam.Text = "Second partial exam: " + studentSubject.secondPartialExam + "b";
        finalExam.Text = "Final exam: " + studentSubject.finalExam + "b";
        int finalGrade = int.Parse(studentSubject.presence) + int.Parse(studentSubject.seminarWork) + int.Parse(studentSubject.homework) + int.Parse(studentSubject.finalExam);
        total.Text = "Total: " + finalGrade.ToString() + "b";
        day.Text = subject.day;
        time.Text = subject.time;
        link.Text = subject.link;
        if (finalGrade < 55) grade.Text = "Grade: 5";
        else if (finalGrade < 65) grade.Text = "Grade: 6";
        else if (finalGrade < 75) grade.Text = "Grade: 7";
        else if (finalGrade < 85) grade.Text = "Grade: 8";
        else if (finalGrade < 95) grade.Text = "Grade: 9";
        else grade.Text = "Grade: 10";

        List<Student> students = _studentSubjectRepository.getStudentsOfClass(subjectId);
        var random = new Random();
        HashSet<int> numbers = new HashSet<int>();
        while (numbers.Count < students.Count) numbers.Add(random.Next(0, students.Count));
        List<int> randNumber = numbers.ToList<int>();
        for (int i = 0; i < students.Count; i++)
        {
            if (i == 0) student1.Source = students[randNumber[i]].profilePhotoUrl;
            else if (i == 1) student2.Source = students[randNumber[i]].profilePhotoUrl;
            else if (i == 2) student3.Source = students[randNumber[i]].profilePhotoUrl;
            else if (i == 3) student4.Source = students[randNumber[i]].profilePhotoUrl;
            else
            {
                student5.Source = students[randNumber[i]].profilePhotoUrl;
                break;
            }
        }
    }

    private async void ActivityPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new ActivityPage());
    }
}