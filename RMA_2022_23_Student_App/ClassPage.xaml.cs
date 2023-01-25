using DocuSign.eSign.Model;
using RMA_2022_23_Student_App.Data;
using RMA_2022_23_Student_App.Models;

namespace RMA_2022_23_Student_App;

public partial class ClassPage : ContentPage
{
    private PresenceRepository _presenceRepository;
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

        string lecturePresenceColor = "#0067ff";
        string exercisePresenceColor = "#ff7272";

        _presenceRepository = new PresenceRepository();
        List<Presence> presences = _presenceRepository.GetAllPresence(TabbeddPage.student.studentId, subjectId);
        if (presences.ElementAtOrDefault(0) != null)
        {
            if (!string.IsNullOrEmpty(presences[0].lectureDate))
            {
                if (presences[0].lecturePresence == 1) weekLecture1.Color = Color.FromHex(lecturePresenceColor);
            }
            if (!string.IsNullOrEmpty(presences[0].exerciseDate))
            {
                if (presences[0].exercisePresence == 1) weekExercise1.Color = Color.FromHex(exercisePresenceColor);
            }            
        }
        if (presences.ElementAtOrDefault(1) != null)
        {
            if (!string.IsNullOrEmpty(presences[1].lectureDate))
            {
                if (presences[1].lecturePresence == 1) weekLecture2.Color = Color.FromHex(lecturePresenceColor);
            }
            if (!string.IsNullOrEmpty(presences[1].exerciseDate))
            {
                if (presences[1].exercisePresence == 1) weekExercise2.Color = Color.FromHex(exercisePresenceColor);
            }
        }
        if (presences.ElementAtOrDefault(2) != null)
        {
            if (!string.IsNullOrEmpty(presences[2].lectureDate))
            {
                if (presences[2].lecturePresence == 1) weekLecture3.Color = Color.FromHex(lecturePresenceColor);
            }
            if (!string.IsNullOrEmpty(presences[2].exerciseDate))
            {
                if (presences[2].exercisePresence == 1) weekExercise3.Color = Color.FromHex(exercisePresenceColor);
            }
        }
        if (presences.ElementAtOrDefault(3) != null)
        {
            if (!string.IsNullOrEmpty(presences[3].lectureDate))
            {
                if (presences[3].lecturePresence == 1) weekLecture4.Color = Color.FromHex(lecturePresenceColor);
            }
            if (!string.IsNullOrEmpty(presences[3].exerciseDate))
            {
                if (presences[3].exercisePresence == 1) weekExercise4.Color = Color.FromHex(exercisePresenceColor);
            }
        }
        if (presences.ElementAtOrDefault(4) != null)
        {
            if (!string.IsNullOrEmpty(presences[4].lectureDate))
            {
                if (presences[4].lecturePresence == 1) weekLecture5.Color = Color.FromHex(lecturePresenceColor);
            }
            if (!string.IsNullOrEmpty(presences[4].exerciseDate))
            {
                if (presences[4].exercisePresence == 1) weekExercise5.Color = Color.FromHex(exercisePresenceColor);
            }
        }
        if (presences.ElementAtOrDefault(5) != null)
        {
            if (!string.IsNullOrEmpty(presences[5].lectureDate))
            {
                if (presences[5].lecturePresence == 1) weekLecture6.Color = Color.FromHex(lecturePresenceColor);
            }
            if (!string.IsNullOrEmpty(presences[5].exerciseDate))
            {
                if (presences[5].exercisePresence == 1) weekExercise6.Color = Color.FromHex(exercisePresenceColor);
            }
        }
        if (presences.ElementAtOrDefault(6) != null)
        {
            if (!string.IsNullOrEmpty(presences[6].lectureDate))
            {
                if (presences[6].lecturePresence == 1) weekLecture7.Color = Color.FromHex(lecturePresenceColor);
            }
            if (!string.IsNullOrEmpty(presences[6].exerciseDate))
            {
                if (presences[6].exercisePresence == 1) weekExercise7.Color = Color.FromHex(exercisePresenceColor);
            }
        }
        if (presences.ElementAtOrDefault(7) != null)
        {
            if (!string.IsNullOrEmpty(presences[7].lectureDate))
            {
                if (presences[7].lecturePresence == 1) weekLecture8.Color = Color.FromHex(lecturePresenceColor);
            }
            if (!string.IsNullOrEmpty(presences[7].exerciseDate))
            {
                if (presences[7].exercisePresence == 1) weekExercise8.Color = Color.FromHex(exercisePresenceColor);
            }
        }
        if (presences.ElementAtOrDefault(8) != null)
        {
            if (!string.IsNullOrEmpty(presences[8].lectureDate))
            {
                if (presences[8].lecturePresence == 1) weekLecture9.Color = Color.FromHex(lecturePresenceColor);
            }
            if (!string.IsNullOrEmpty(presences[8].exerciseDate))
            {
                if (presences[8].exercisePresence == 1) weekExercise9.Color = Color.FromHex(exercisePresenceColor);
            }
        }
        if (presences.ElementAtOrDefault(9) != null)
        {
            if (!string.IsNullOrEmpty(presences[9].lectureDate))
            {
                if (presences[9].lecturePresence == 1) weekLecture10.Color = Color.FromHex(lecturePresenceColor);
            }
            if (!string.IsNullOrEmpty(presences[9].exerciseDate))
            {
                if (presences[9].exercisePresence == 1) weekExercise10.Color = Color.FromHex(exercisePresenceColor);
            }
        }
        if (presences.ElementAtOrDefault(10) != null)
        {
            if (!string.IsNullOrEmpty(presences[10].lectureDate))
            {
                if (presences[10].lecturePresence == 1) weekLecture11.Color = Color.FromHex(lecturePresenceColor);
            }
            if (!string.IsNullOrEmpty(presences[10].exerciseDate))
            {
                if (presences[10].exercisePresence == 1) weekExercise11.Color = Color.FromHex(exercisePresenceColor);
            }
        }
        if (presences.ElementAtOrDefault(11) != null)
        {
            if (!string.IsNullOrEmpty(presences[11].lectureDate))
            {
                if (presences[11].lecturePresence == 1) weekLecture12.Color = Color.FromHex(lecturePresenceColor);
            }
            if (!string.IsNullOrEmpty(presences[11].exerciseDate))
            {
                if (presences[11].exercisePresence == 1) weekExercise12.Color = Color.FromHex(exercisePresenceColor);
            }
        }
        if (presences.ElementAtOrDefault(12) != null)
        {
            if (!string.IsNullOrEmpty(presences[12].lectureDate))
            {
                if (presences[12].lecturePresence == 1) weekLecture13.Color = Color.FromHex(lecturePresenceColor);
            }
            if (!string.IsNullOrEmpty(presences[12].exerciseDate))
            {
                if (presences[12].exercisePresence == 1) weekExercise13.Color = Color.FromHex(exercisePresenceColor);
            }
        }
        if (presences.ElementAtOrDefault(13) != null)
        {
            if (!string.IsNullOrEmpty(presences[13].lectureDate))
            {
                if (presences[13].lecturePresence == 1) weekLecture14.Color = Color.FromHex(lecturePresenceColor);
            }
            if (!string.IsNullOrEmpty(presences[13].exerciseDate))
            {
                if (presences[13].exercisePresence == 1) weekExercise14.Color = Color.FromHex(exercisePresenceColor);
            }
        }
        if (presences.ElementAtOrDefault(14) != null)
        {
            if (!string.IsNullOrEmpty(presences[14].lectureDate))
            {
                if (presences[14].lecturePresence == 1) weekLecture15.Color = Color.FromHex(lecturePresenceColor);
            }
            if (!string.IsNullOrEmpty(presences[14].exerciseDate))
            {
                if (presences[14].exercisePresence == 1) weekExercise15.Color = Color.FromHex(exercisePresenceColor);
            }
        }
        if (presences.ElementAtOrDefault(15) != null)
        {
            if (!string.IsNullOrEmpty(presences[15].lectureDate))
            {
                if (presences[15].lecturePresence == 1) weekLecture16.Color = Color.FromHex(lecturePresenceColor);
            }
            if (!string.IsNullOrEmpty(presences[15].exerciseDate))
            {
                if (presences[15].exercisePresence == 1) weekExercise16.Color = Color.FromHex(exercisePresenceColor);
            }
        }

        activityPage.ClassId = subjectId.ToString();
    }

    private async void ActivityPageClicked(object sender, EventArgs e)
    {
        Button b = sender as Button;
        var subjectId = b.ClassId;
        await Navigation.PushModalAsync(new ActivityPage(int.Parse(subjectId)));
    }
}