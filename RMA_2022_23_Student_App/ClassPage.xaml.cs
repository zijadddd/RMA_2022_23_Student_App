using DocuSign.eSign.Model;
using RMA_2022_23_Student_App.Data;
using RMA_2022_23_Student_App.Models;

namespace RMA_2022_23_Student_App;

public partial class ClassPage : ContentPage
{
    private StudentSubjectRepository _studentSubjectRepository;
    private PresenceRepository _presenceRepository;
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
        Presence[] presencesTemp = new Presence[16];
        for (int i = 0; i < 16; i++) presencesTemp = null;
        for (int i = 0; i < presences.Count; i++) presencesTemp[i] = presences[i];
        subjectName.Text = presences.Count.ToString();
        /*if (presencesTemp[0] != null)
        {
            if (!string.IsNullOrEmpty(presencesTemp[0].lecturesDate)) weekLecture1.Color = Color.FromHex(lecturePresenceColor);
            if (!string.IsNullOrEmpty(presencesTemp[0].exerciseDate)) weekExercise1.Color = Color.FromHex(exercisePresenceColor);
        }
        if (presencesTemp[1] != null)
        {
            if (!string.IsNullOrEmpty(presencesTemp[1].lecturesDate)) weekLecture2.Color = Color.FromHex(lecturePresenceColor);
            if (!string.IsNullOrEmpty(presencesTemp[1].exerciseDate)) weekExercise2.Color = Color.FromHex(exercisePresenceColor);
        }
        if (presencesTemp[2] != null)
        {
            if (!string.IsNullOrEmpty(presencesTemp[2].lecturesDate)) weekLecture3.Color = Color.FromHex(lecturePresenceColor);
            if (!string.IsNullOrEmpty(presencesTemp[2].exerciseDate)) weekExercise3.Color = Color.FromHex(exercisePresenceColor);
        }
        if (presencesTemp[3] != null)
        {
            if (!string.IsNullOrEmpty(presencesTemp[3].lecturesDate)) weekLecture4.Color = Color.FromHex(lecturePresenceColor);
            if (!string.IsNullOrEmpty(presencesTemp[3].exerciseDate)) weekExercise4.Color = Color.FromHex(exercisePresenceColor);
        }
        if (presencesTemp[4] != null)
        {
            if (!string.IsNullOrEmpty(presencesTemp[4].lecturesDate)) weekLecture5.Color = Color.FromHex(lecturePresenceColor);
            if (!string.IsNullOrEmpty(presencesTemp[4].exerciseDate)) weekExercise5.Color = Color.FromHex(exercisePresenceColor);
        }
        if (presencesTemp[5] != null)
        {
            if (!string.IsNullOrEmpty(presencesTemp[5].lecturesDate)) weekLecture6.Color = Color.FromHex(lecturePresenceColor);
            if (!string.IsNullOrEmpty(presencesTemp[5].exerciseDate)) weekExercise6.Color = Color.FromHex(exercisePresenceColor);
        }
        if (presencesTemp[6] != null)
        {
            if (!string.IsNullOrEmpty(presencesTemp[6].lecturesDate)) weekLecture7.Color = Color.FromHex(lecturePresenceColor);
            if (!string.IsNullOrEmpty(presencesTemp[6].exerciseDate)) weekExercise7.Color = Color.FromHex(exercisePresenceColor);
        }
        if (presencesTemp[7] != null)
        {
            if (!string.IsNullOrEmpty(presencesTemp[7].lecturesDate)) weekLecture8.Color = Color.FromHex(lecturePresenceColor);
            if (!string.IsNullOrEmpty(presencesTemp[7].exerciseDate)) weekExercise8.Color = Color.FromHex(exercisePresenceColor);
        }
        if (presencesTemp[8] != null)
        {
            if (!string.IsNullOrEmpty(presencesTemp[8].lecturesDate)) weekLecture9.Color = Color.FromHex(lecturePresenceColor);
            if (!string.IsNullOrEmpty(presencesTemp[8].exerciseDate)) weekExercise9.Color = Color.FromHex(exercisePresenceColor);
        }
        if (presencesTemp[9] != null)
        {
            if (!string.IsNullOrEmpty(presencesTemp[9].lecturesDate)) weekLecture10.Color = Color.FromHex(lecturePresenceColor);
            if (!string.IsNullOrEmpty(presencesTemp[9].exerciseDate)) weekExercise10.Color = Color.FromHex(exercisePresenceColor);
        }
        if (presencesTemp[10] != null)
        {
            if (!string.IsNullOrEmpty(presencesTemp[10].lecturesDate)) weekLecture11.Color = Color.FromHex(lecturePresenceColor);
            if (!string.IsNullOrEmpty(presencesTemp[10].exerciseDate)) weekExercise11.Color = Color.FromHex(exercisePresenceColor);
        }
        if (presencesTemp[11] != null)
        {
            if (!string.IsNullOrEmpty(presencesTemp[11].lecturesDate)) weekLecture12.Color = Color.FromHex(lecturePresenceColor);
            if (!string.IsNullOrEmpty(presencesTemp[11].exerciseDate)) weekExercise12.Color = Color.FromHex(exercisePresenceColor);
        }
        if (presencesTemp[12] != null)
        {
            if (!string.IsNullOrEmpty(presencesTemp[12].lecturesDate)) weekLecture13.Color = Color.FromHex(lecturePresenceColor);
            if (!string.IsNullOrEmpty(presencesTemp[12].exerciseDate)) weekExercise13.Color = Color.FromHex(exercisePresenceColor);
        }
        if (presencesTemp[13] != null)
        {
            if (!string.IsNullOrEmpty(presencesTemp[13].lecturesDate)) weekLecture14.Color = Color.FromHex(lecturePresenceColor);
            if (!string.IsNullOrEmpty(presencesTemp[13].exerciseDate)) weekExercise14.Color = Color.FromHex(exercisePresenceColor);
        }
        if (presencesTemp[14] != null)
        {
            if (!string.IsNullOrEmpty(presencesTemp[14].lecturesDate)) weekLecture15.Color = Color.FromHex(lecturePresenceColor);
            if (!string.IsNullOrEmpty(presencesTemp[14].exerciseDate)) weekExercise15.Color = Color.FromHex(exercisePresenceColor);
        }
        if (presencesTemp[15] != null)
        {
            if (!string.IsNullOrEmpty(presencesTemp[15].lecturesDate)) weekLecture16.Color = Color.FromHex(lecturePresenceColor);
            if (!string.IsNullOrEmpty(presencesTemp[15].exerciseDate)) weekExercise16.Color = Color.FromHex(exercisePresenceColor);
        } */
    }

    private async void ActivityPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new ActivityPage());
    }
}