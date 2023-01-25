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
        PresenceRepository _presenceRepository = new PresenceRepository();

        _studentRepository.AddNewStudent(1, "Zijad", "Doglod", "11.10.2001", "Zenica", "060 324 0384", "zijad@gmail.com", "123456", "185", "UNZE", "PTF", "SI", "Ja sam Zijad Doglod i dolazim iz mjesta zvano Tetovo u blizini Zenice.", "people1.jpg");
        _studentRepository.AddNewStudent(2, "Muhamed", "Haseljic", "23.05.2001", "Vjetrenice", "060 555 4444", "muhamed@gmail.com", "654321", "185", "UNZE", "PTF", "SI", "Ja sam Muhamed Haseljic i ne dajem puno informacija o sebi.", "people2.jpeg");
        _studentRepository.AddNewStudent(3, "Suljo", "Suljic", "16.8.2002", "Kakanj", "060 452 671", "suljo@gmail.com", "komp", "184", "UNZE", "PTF", "SI", "Ja sam Suljo Suljic i dolazim iz mjesta zvano Bašići u blizini Kaknja.", "people3.jpeg");
        _studentRepository.AddNewStudent(4, "Suljo", "Suljic", "16.8.2002", "Kakanj", "060 452 671", "sulo@gmail.com", "komp", "182", "UNZE", "PTF", "SI", "Ja sam Suljo Suljic i dolazim iz mjesta zvano Bašići u blizini Kaknja.", "people4.jpg");
        _studentRepository.AddNewStudent(5, "Zijada", "Ramoni", "23.05.2001", "Zanzibar", "060 555 333", "mlada@gmail.com", "komp", "186", "UNZE", "PTF", "SI", "Ja sam Zijada Ramoni i dolazim iz Zanzibara blizu Nigdjezemlje.", "people5.jpg");

        _subjectRepository.addNewSubject(1, "Razvoj mobilnih aplikacija", "Esad Kadušić", "socialmedia.png", "#cde7fc", "#AA3e8dfd", "Every Monday", "15:30 - 17:30", "meet.google.com/puj-fkho-yuw");
        _subjectRepository.addNewSubject(2, "Web programiranje", "Đulaga Hadžić", "subjectone.png", "#e6ceff", "#AAd078ff", "Every Tuesday", "09:15 - 12:15", "meet.google.com/koj-lghu-zuj");
        _subjectRepository.addNewSubject(3, "Uvod u tehnike programiranja", "Adnan Dželihođić", "socialmedia.png", "#cde7fc", "#AA3e8dfd", "Every Wednesday", "12:15 - 15:15", "meet.google.com/rik-pfpo-jok");
        _subjectRepository.addNewSubject(4, "Razvoj softvera", "Mujo Hodzic", "socialmedia.png", "#dcffce", "#AA8ed385", "Every Friday", "15:15 - 17:00", "meet.google.com/jus-zvyt-joq");
        _subjectRepository.addNewSubject(5, "Embedded i Real Time sistemi", "Elmir Babovic", "subjectone.png", "#ffcdd2", "#AAe57373", "Every Friday", "17:15 - 19:00", "meet.google.com/aqm-oexz-ikb");

        _studentSubjectRepository.addStudentToSubject(1, 1, 0, "10", "10", "8", "23", "33", "56");
        _studentSubjectRepository.addStudentToSubject(1, 2, 1, "4", "12", "10", "10", "36", "46");
        _studentSubjectRepository.addStudentToSubject(1, 3, 2, "14", "15", "5", "21", "39", "60");
        _studentSubjectRepository.addStudentToSubject(1, 4, 0, "14", "15", "5", "21", "39", "60");
        _studentSubjectRepository.addStudentToSubject(1, 5, 0, "10", "60", "10", "0", "0", "0");

        _studentSubjectRepository.addStudentToSubject(2, 1, 0, "10", "10", "10", "23", "33", "56");
        _studentSubjectRepository.addStudentToSubject(2, 2, 1, "4", "12", "8", "10", "36", "46");
        _studentSubjectRepository.addStudentToSubject(2, 3, 2, "14", "15", "6", "21", "39", "60");
        _studentSubjectRepository.addStudentToSubject(2, 4, 0, "8", "15", "5", "5", "1", "6");
        _studentSubjectRepository.addStudentToSubject(2, 5, 0, "10", "15", "10", "25", "40", "65");

        _studentSubjectRepository.addStudentToSubject(3, 1, 0, "10", "10", "10", "23", "33", "56");
        _studentSubjectRepository.addStudentToSubject(3, 2, 1, "4", "12", "8", "10", "36", "46");
        _studentSubjectRepository.addStudentToSubject(3, 3, 2, "14", "15", "6", "21", "39", "60");
        _studentSubjectRepository.addStudentToSubject(3, 4, 0, "8", "15", "5", "5", "1", "6");
        _studentSubjectRepository.addStudentToSubject(3, 5, 0, "10", "15", "10", "25", "40", "65");

        _studentSubjectRepository.addStudentToSubject(4, 1, 0, "10", "10", "10", "23", "33", "56");
        _studentSubjectRepository.addStudentToSubject(4, 2, 1, "4", "12", "8", "10", "36", "46");
        _studentSubjectRepository.addStudentToSubject(4, 3, 2, "14", "15", "6", "21", "39", "60");
        _studentSubjectRepository.addStudentToSubject(4, 4, 0, "8", "15", "5", "5", "1", "6");
        _studentSubjectRepository.addStudentToSubject(4, 5, 0, "10", "15", "10", "25", "40", "65");

        _studentSubjectRepository.addStudentToSubject(5, 1, 0, "10", "10", "10", "23", "33", "56");
        _studentSubjectRepository.addStudentToSubject(5, 2, 1, "4", "12", "8", "10", "36", "46");
        _studentSubjectRepository.addStudentToSubject(5, 3, 2, "14", "15", "6", "21", "39", "60");
        _studentSubjectRepository.addStudentToSubject(5, 4, 0, "8", "15", "5", "5", "1", "6");
        _studentSubjectRepository.addStudentToSubject(5, 5, 0, "10", "15", "10", "25", "40", "65");

        _presenceRepository.addPresence(1, 1, "2020-08-23", "2020-07-31", 1, 1);
        _presenceRepository.addPresence(1, 1, "2020-08-22", "2020-07-29", 1, 0);
        _presenceRepository.addPresence(1, 2, "2020-08-21", "2020-07-28", 0, 0);
        _presenceRepository.addPresence(1, 2, "2020-08-20", "2020-07-27", 1, 0);

        BindingContext = this;
    }

    private async void LoginClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new Login();
    }
}

