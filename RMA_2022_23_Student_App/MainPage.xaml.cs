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

        _subjectRepository.addNewSubject(1, "Razvoj mobilnih aplikacija", "Esad Kadušić", "socialmedia.png", "#cde7fc", "#AA3e8dfd");
        _subjectRepository.addNewSubject(2, "Web programiranje", "Đulaga Hadžić", "subjectone.png", "#e6ceff", "#AAd078ff");
        _subjectRepository.addNewSubject(3, "Uvod u tehnike programiranja", "Adnan Dželihođić", "socialmedia.png", "#cde7fc", "#AA3e8dfd");

        _studentSubjectRepository.addStudentToSubject(1, 1, 0 ,"10b", "10b", "23b", "33b", "56b");
        _studentSubjectRepository.addStudentToSubject(1, 2, 1, "4b", "12b", "10b", "36b", "46b");
        _studentSubjectRepository.addStudentToSubject(1, 3, 2, "14b", "15b", "21b", "39b", "60b");

        _studentSubjectRepository.addStudentToSubject(2, 1, 0, "10b", "10b", "23b", "33b", "56b");
        _studentSubjectRepository.addStudentToSubject(2, 2, 1, "4b", "12b", "10b", "36b", "46b");
        _studentSubjectRepository.addStudentToSubject(2, 3, 2, "14b", "15b", "21b", "39b", "60b");

        BindingContext = this;
    }

    private async void LoginClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new Login();
    }
    private async void RegistrationClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Registration());
    }
}

