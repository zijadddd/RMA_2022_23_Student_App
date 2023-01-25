using RMA_2022_23_Student_App.Data;

namespace RMA_2022_23_Student_App;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
        StudentRepository _studentRepository = new StudentRepository();
        SubjectRepository _subjectRepository = new SubjectRepository();
        StudentSubjectRepository _studentSubjectRepository = new StudentSubjectRepository();    

        _studentRepository.AddNewStudent(1, "Zijad", "Doglod", "11.10.2001", "Zenica", "060 324 0384", "zijad@gmail.com", "123456", "185", "UNZE", "PTF", "SI", "Ja sam Zijad Doglod i dolazim iz mjesta zvano Tetovo u blizini Zenice.", "people1.jpg");
        _studentRepository.AddNewStudent(2, "Muhamed", "Haseljic", "23.05.2001", "Vjetrenice", "060 555 4444", "muhamed@gmail.com", "654321", "185", "UNZE", "PTF", "SI", "Ja sam Muhamed Haseljic i ne dajem puno informacija o sebi.", "people4.jpg");

        _subjectRepository.addNewSubject(1, "Razvoj mobilnih aplikacija", "Esad Kadušić", "socialmedia.png", "#cde7fc", "#AA3e8dfd", "Every Monday", "15:30 - 17:30", "meet.google.com/puj-fkho-yuw");
        _subjectRepository.addNewSubject(2, "Web programiranje", "Đulaga Hadžić", "subjectone.png", "#e6ceff", "#AAd078ff", "Every Tuesday", "09:15 - 12:15", "meet.google.com/koj-lghu-zuj");
        _subjectRepository.addNewSubject(3, "Uvod u tehnike programiranja", "Adnan Dželihođić", "socialmedia.png", "#cde7fc", "#AA3e8dfd", "Every Wednesday", "12:15 - 15:15", "meet.google.com/rik-pfpo-jok");

        _studentSubjectRepository.addStudentToSubject(1, 1, 0 ,"10", "10", "8" ,"23", "33", "56");
        _studentSubjectRepository.addStudentToSubject(1, 2, 1, "4", "12", "10" ,"10", "36", "46");
        _studentSubjectRepository.addStudentToSubject(1, 3, 2, "14", "15", "5" ,"21", "39", "60");

        _studentSubjectRepository.addStudentToSubject(2, 1, 0, "10", "10", "10" ,"23", "33", "56");
        _studentSubjectRepository.addStudentToSubject(2, 2, 1, "4", "12", "8" ,"10", "36", "46");
        _studentSubjectRepository.addStudentToSubject(2, 3, 2, "14", "15", "6" ,"21", "39", "60");

        BindingContext = this;
    }

    private async void LoginClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new Login();
    }
}

