using RMA_2022_23_Student_App.Data;

namespace RMA_2022_23_Student_App;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
        StudentRepository _studentRepository = new StudentRepository();
        SubjectRepository _subjectRepository = new SubjectRepository();
        PresenceRepository _presenceRepository = new PresenceRepository();
        StudentSubjectRepository _studentSubjectRepository = new StudentSubjectRepository();

        _studentRepository.AddNewStudent(1, "Zijad", "Doglod", "11.10.2001", "Zenica", "060 324 0384", "zijad@gmail.com", "123456", "185", "UNZE", "PTF", "SI", "A highly motivated second year Software engineering Student with all\r\npassed subjects through four semesters. My studies have taught me\r\nstrong programming and problem solving skills in the way I can, in a\r\nrelatively short time, adopt to the problem and solve it. I'm also offering\r\nstrong experience with many programming tools, logical approach and\r\nmany other advanced computer skills. I am ready to utilize my skills and\r\npassion to further the mission of a company. I can say for myself that I am\r\nhardworking, ambitious, well organized and motivational individual with a\r\nstrong passion in Information Technology sector.", "person1.jpg");
        _studentRepository.AddNewStudent(2, "Muhamed", "Haseljic", "23.05.2001", "Vjetrenice", "060 555 4444", "muhamed@gmail.com", "654321", "185", "UNZE", "PTF", "SI", "Ja sam Muhamed Haseljic i dolazim iz mjesta zvano Vjetrenice u blizini Zenice.", "person4.jpg");
        _studentRepository.AddNewStudent(3, "Ajla", "Doglod", "16.8.2002", "Kakanj", "060 452 671", "ajla@gmail.com", "komp", "184", "UNZE", "PTF", "SI", "Ja sam Suljo Suljic i dolazim iz mjesta zvano Bašići u blizini Kaknja.", "person3.jpg");
        _studentRepository.AddNewStudent(4, "Sedina", "Selimovic", "16.8.2002", "Kakanj", "060 452 671", "sedina@gmail.com", "komp", "182", "UNZE", "PTF", "SI", "Ja sam Suljo Suljic i dolazim iz mjesta zvano Bašići u blizini Kaknja.", "person4.jpg");
        _studentRepository.AddNewStudent(5, "Ramiz", "Bajramovic", "23.05.2001", "Vitez", "060 555 333", "ramiz@gmail.com", "komp", "186", "UNZE", "PTF", "SI", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec blandit laoreet risus et imperdiet. In molestie in arcu eget ornare.", "person5.jpg");
        _studentRepository.AddNewStudent(6, "Ramiz", "Heleg", "23.05.2001", "Zenica", "060 555 333", "ramiz@gmail.com", "komp", "186", "UNZE", "PTF", "SI", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec blandit laoreet risus et imperdiet. In molestie in arcu eget ornare.", "person6.jpg");
        _studentRepository.AddNewStudent(7, "Samid", "Badnjar", "23.05.2001", "Sarajevo", "060 555 333", "samid@gmail.com", "komp", "186", "UNZE", "PTF", "SI", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec blandit laoreet risus et imperdiet. In molestie in arcu eget ornare.", "person7.jpg");
        _studentRepository.AddNewStudent(8, "Samir", "Mujanovic", "23.05.2001", "Zepce", "060 555 333", "samir@gmail.com", "komp", "186", "UNZE", "PTF", "SI", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec blandit laoreet risus et imperdiet. In molestie in arcu eget ornare.", "person8.jpg");
        _studentRepository.AddNewStudent(9, "Ajdin", "Avdic", "23.05.2001", "Doboj", "060 555 333", "ajdin@gmail.com", "komp", "186", "UNZE", "PTF", "SI", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec blandit laoreet risus et imperdiet. In molestie in arcu eget ornare.", "person9.jpg");
        _studentRepository.AddNewStudent(10, "Halid", "Kalabuzic", "23.05.2001", "Kakanj", "060 555 333", "halid@gmail.com", "komp", "186", "UNZE", "PTF", "SI", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec blandit laoreet risus et imperdiet. In molestie in arcu eget ornare.", "person10.jpg");
        _studentRepository.AddNewStudent(11, "Azem", "Sarajcic", "23.05.2001", "Bugojno", "060 555 333", "azem@gmail.com", "komp", "186", "UNZE", "PTF", "SI", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec blandit laoreet risus et imperdiet. In molestie in arcu eget ornare.", "person11.jpg");
        _studentRepository.AddNewStudent(12, "Selim", "Šišman", "23.05.2001", "Mostar", "060 555 333", "selim@gmail.com", "komp", "186", "UNZE", "PTF", "SI", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec blandit laoreet risus et imperdiet. In molestie in arcu eget ornare.", "person12.jpg");

        _subjectRepository.addNewSubject(1, "Razvoj mobilnih aplikacija", "Esad Kadušić", "socialmedia.png", "#cde7fc", "#AA3e8dfd", "Every Monday", "15:30 - 17:30", "meet.google.com/puj-fkho-yuw");
        _subjectRepository.addNewSubject(2, "Web programiranje", "Đulaga Hadžić", "subjectone.png", "#e6ceff", "#AAd078ff", "Every Tuesday", "09:15 - 12:15", "meet.google.com/koj-lghu-zuj");
        _subjectRepository.addNewSubject(3, "Uvod u tehnike programiranja", "Adnan Dželihođić", "socialmedia.png", "#cfd8dc", "#AA78909c", "Every Wednesday", "12:15 - 15:15", "meet.google.com/rik-pfpo-jok");
        _subjectRepository.addNewSubject(4, "Razvoj softvera", "Mujo Hodzic", "socialmedia.png", "#dcffce", "#AA8ed385", "Every Friday", "15:15 - 17:00", "meet.google.com/jus-zvyt-joq");
        _subjectRepository.addNewSubject(5, "Embedded i Real Time sistemi", "Elmir Babovic", "subjectone.png", "#ffcdd2", "#AAe57373", "Every Friday", "17:15 - 19:00", "meet.google.com/aqm-oexz-ikb");
        _subjectRepository.addNewSubject(6, "Sistemska i mrežna administracija", "Enes Saletović", "socialmedia.png", "#cde7fc", "#AA3e8dfd", "Every Monday", "12:15 - 15:15", "meet.google.com/rik-pfpo-jok");
        _subjectRepository.addNewSubject(7, "Napredne tehnike programiranja", "Adnan Dželihođić", "subjectone.png", "#e6ceff", "#AAd078ff", "Every Tuesday", "15:15 - 17:00", "meet.google.com/jus-zvyt-joq");
        _subjectRepository.addNewSubject(8, "Napredne baze podataka", "Jasmin Azemović", "socialmedia.png", "#cfd8dc", "#AA78909c", "Every Friday", "17:15 - 19:00", "meet.google.com/aqm-oexz-ikb");

        _studentSubjectRepository.addStudentToSubject(1, 1, 0, "10", "10", "8", "23", "33", "56");
        _studentSubjectRepository.addStudentToSubject(1, 2, 1, "4", "12", "10", "10", "36", "46");
        _studentSubjectRepository.addStudentToSubject(1, 3, 2, "14", "15", "5", "21", "39", "60");
        _studentSubjectRepository.addStudentToSubject(1, 4, 0, "14", "15", "5", "21", "39", "60");
        _studentSubjectRepository.addStudentToSubject(1, 5, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(1, 6, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(1, 7, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(1, 8, 0, "10", "60", "10", "0", "0", "0");

        _studentSubjectRepository.addStudentToSubject(2, 1, 0, "10", "10", "10", "23", "33", "56");
        _studentSubjectRepository.addStudentToSubject(2, 2, 1, "4", "12", "8", "10", "36", "46");
        _studentSubjectRepository.addStudentToSubject(2, 3, 2, "14", "15", "6", "21", "39", "60");
        _studentSubjectRepository.addStudentToSubject(2, 4, 0, "8", "15", "5", "5", "1", "6");
        _studentSubjectRepository.addStudentToSubject(2, 5, 0, "10", "15", "10", "25", "40", "65");
        _studentSubjectRepository.addStudentToSubject(2, 6, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(2, 7, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(2, 8, 0, "10", "60", "10", "0", "0", "0");

        _studentSubjectRepository.addStudentToSubject(3, 1, 0, "10", "10", "10", "23", "33", "56");
        _studentSubjectRepository.addStudentToSubject(3, 2, 1, "4", "12", "8", "10", "36", "46");
        _studentSubjectRepository.addStudentToSubject(3, 3, 2, "14", "15", "6", "21", "39", "60");
        _studentSubjectRepository.addStudentToSubject(3, 4, 0, "8", "15", "5", "5", "1", "6");
        _studentSubjectRepository.addStudentToSubject(3, 5, 0, "10", "15", "10", "25", "40", "65");
        _studentSubjectRepository.addStudentToSubject(3, 6, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(3, 7, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(3, 8, 0, "10", "60", "10", "0", "0", "0");

        _studentSubjectRepository.addStudentToSubject(4, 1, 0, "10", "10", "10", "23", "33", "56");
        _studentSubjectRepository.addStudentToSubject(4, 2, 1, "4", "12", "8", "10", "36", "46");
        _studentSubjectRepository.addStudentToSubject(4, 3, 2, "14", "15", "6", "21", "39", "60");
        _studentSubjectRepository.addStudentToSubject(4, 4, 0, "8", "15", "5", "5", "1", "6");
        _studentSubjectRepository.addStudentToSubject(4, 5, 0, "10", "15", "10", "25", "40", "65");
        _studentSubjectRepository.addStudentToSubject(4, 6, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(4, 7, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(4, 8, 0, "10", "60", "10", "0", "0", "0");

        _studentSubjectRepository.addStudentToSubject(5, 1, 0, "10", "10", "10", "23", "33", "56");
        _studentSubjectRepository.addStudentToSubject(5, 2, 1, "4", "12", "8", "10", "36", "46");
        _studentSubjectRepository.addStudentToSubject(5, 3, 2, "14", "15", "6", "21", "39", "60");
        _studentSubjectRepository.addStudentToSubject(5, 4, 0, "8", "15", "5", "5", "1", "6");
        _studentSubjectRepository.addStudentToSubject(5, 5, 0, "10", "15", "10", "25", "40", "65");
        _studentSubjectRepository.addStudentToSubject(5, 6, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(5, 7, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(5, 8, 0, "10", "60", "10", "0", "0", "0");

        _studentSubjectRepository.addStudentToSubject(6, 1, 0, "10", "10", "10", "23", "33", "56");
        _studentSubjectRepository.addStudentToSubject(6, 2, 1, "4", "12", "8", "10", "36", "46");
        _studentSubjectRepository.addStudentToSubject(6, 3, 2, "14", "15", "6", "21", "39", "60");
        _studentSubjectRepository.addStudentToSubject(6, 4, 0, "8", "15", "5", "5", "1", "6");
        _studentSubjectRepository.addStudentToSubject(6, 5, 0, "10", "15", "10", "25", "40", "65");
        _studentSubjectRepository.addStudentToSubject(6, 6, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(6, 7, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(6, 8, 0, "10", "60", "10", "0", "0", "0");

        _studentSubjectRepository.addStudentToSubject(7, 1, 0, "10", "10", "10", "23", "33", "56");
        _studentSubjectRepository.addStudentToSubject(7, 2, 1, "4", "12", "8", "10", "36", "46");
        _studentSubjectRepository.addStudentToSubject(7, 3, 2, "14", "15", "6", "21", "39", "60");
        _studentSubjectRepository.addStudentToSubject(7, 4, 0, "8", "15", "5", "5", "1", "6");
        _studentSubjectRepository.addStudentToSubject(7, 5, 0, "10", "15", "10", "25", "40", "65");
        _studentSubjectRepository.addStudentToSubject(7, 6, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(7, 7, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(7, 8, 0, "10", "60", "10", "0", "0", "0");

        _studentSubjectRepository.addStudentToSubject(8, 1, 0, "10", "10", "10", "23", "33", "56");
        _studentSubjectRepository.addStudentToSubject(8, 2, 1, "4", "12", "8", "10", "36", "46");
        _studentSubjectRepository.addStudentToSubject(8, 3, 2, "14", "15", "6", "21", "39", "60");
        _studentSubjectRepository.addStudentToSubject(8, 4, 0, "8", "15", "5", "5", "1", "6");
        _studentSubjectRepository.addStudentToSubject(8, 5, 0, "10", "15", "10", "25", "40", "65");
        _studentSubjectRepository.addStudentToSubject(8, 6, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(8, 7, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(8, 8, 0, "10", "60", "10", "0", "0", "0");

        _studentSubjectRepository.addStudentToSubject(9, 1, 0, "10", "10", "10", "23", "33", "56");
        _studentSubjectRepository.addStudentToSubject(9, 2, 1, "4", "12", "8", "10", "36", "46");
        _studentSubjectRepository.addStudentToSubject(9, 3, 2, "14", "15", "6", "21", "39", "60");
        _studentSubjectRepository.addStudentToSubject(9, 4, 0, "8", "15", "5", "5", "1", "6");
        _studentSubjectRepository.addStudentToSubject(9, 5, 0, "10", "15", "10", "25", "40", "65");
        _studentSubjectRepository.addStudentToSubject(9, 6, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(9, 7, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(9, 8, 0, "10", "60", "10", "0", "0", "0");

        _studentSubjectRepository.addStudentToSubject(10, 1, 0, "10", "10", "10", "23", "33", "56");
        _studentSubjectRepository.addStudentToSubject(10, 2, 1, "4", "12", "8", "10", "36", "46");
        _studentSubjectRepository.addStudentToSubject(10, 3, 2, "14", "15", "6", "21", "39", "60");
        _studentSubjectRepository.addStudentToSubject(10, 4, 0, "8", "15", "5", "5", "1", "6");
        _studentSubjectRepository.addStudentToSubject(10, 5, 0, "10", "15", "10", "25", "40", "65");
        _studentSubjectRepository.addStudentToSubject(10, 6, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(10, 7, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(10, 8, 0, "10", "60", "10", "0", "0", "0");

        _studentSubjectRepository.addStudentToSubject(11, 1, 0, "10", "10", "10", "23", "33", "56");
        _studentSubjectRepository.addStudentToSubject(11, 2, 1, "4", "12", "8", "10", "36", "46");
        _studentSubjectRepository.addStudentToSubject(11, 3, 2, "14", "15", "6", "21", "39", "60");
        _studentSubjectRepository.addStudentToSubject(11, 4, 0, "8", "15", "5", "5", "1", "6");
        _studentSubjectRepository.addStudentToSubject(11, 5, 0, "10", "15", "10", "25", "40", "65");
        _studentSubjectRepository.addStudentToSubject(11, 6, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(11, 7, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(11, 8, 0, "10", "60", "10", "0", "0", "0");

        _studentSubjectRepository.addStudentToSubject(12, 1, 0, "10", "10", "10", "23", "33", "56");
        _studentSubjectRepository.addStudentToSubject(12, 2, 1, "4", "12", "8", "10", "36", "46");
        _studentSubjectRepository.addStudentToSubject(12, 3, 2, "14", "15", "6", "21", "39", "60");
        _studentSubjectRepository.addStudentToSubject(12, 4, 0, "8", "15", "5", "5", "1", "6");
        _studentSubjectRepository.addStudentToSubject(12, 5, 0, "10", "15", "10", "25", "40", "65");
        _studentSubjectRepository.addStudentToSubject(12, 6, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(12, 7, 0, "10", "60", "10", "0", "0", "0");
        _studentSubjectRepository.addStudentToSubject(12, 8, 0, "10", "60", "10", "0", "0", "0");

        _presenceRepository.addPresence(1, 1, 1, "2022-10-02", "2022-10-04", 1, 1);
        _presenceRepository.addPresence(1, 1, 2, "2022-10-09", "2022-10-11", 1, 0);
        _presenceRepository.addPresence(1, 1, 3, "2022-10-16", "2022-10-18", 1, 1);
        _presenceRepository.addPresence(1, 1, 4, "2022-10-23", "2022-10-25", 1, 0);
        _presenceRepository.addPresence(1, 1, 5, "2022-10-30", "2022-11-01", 1, 1);
        _presenceRepository.addPresence(1, 1, 6, "2022-11-05", "2022-11-08", 1, 1);
        _presenceRepository.addPresence(1, 1, 7, "2022-11-12", "2022-11-15", 1, 1);
        _presenceRepository.addPresence(1, 1, 8, "2022-11-19", "2022-11-22", 1, 1);

        _presenceRepository.addPresence(1, 2, 1, "2022-10-02", "2022-10-04", 1, 1);
        _presenceRepository.addPresence(1, 2, 2, "2022-10-09", "2022-10-11", 1, 0);
        _presenceRepository.addPresence(1, 2, 3, "2022-10-16", "2022-10-18", 1, 1);
        _presenceRepository.addPresence(1, 2, 4, "2022-10-23", "2022-10-25", 1, 0);
        _presenceRepository.addPresence(1, 2, 5, "2022-10-30", "2022-11-01", 1, 1);
        _presenceRepository.addPresence(1, 2, 6, "2022-11-05", "2022-11-08", 1, 1);
        _presenceRepository.addPresence(1, 2, 7, "2022-11-12", "2022-11-15", 1, 1);
        _presenceRepository.addPresence(1, 2, 8, "2022-11-19", "2022-11-22", 1, 1);

        // 2. student
        _presenceRepository.addPresence(2, 1, 1, "2022-10-02", "2022-10-04", 1, 1);
        _presenceRepository.addPresence(2, 1, 2, "2022-10-09", "2022-10-11", 1, 0);
        _presenceRepository.addPresence(2, 1, 3, "2022-10-16", "2022-10-18", 1, 1);
        _presenceRepository.addPresence(2, 1, 4, "2022-10-23", "2022-10-25", 1, 0);
        _presenceRepository.addPresence(2, 1, 5, "2022-10-30", "2022-11-01", 1, 1);
        _presenceRepository.addPresence(2, 1, 6, "2022-11-05", "2022-11-08", 1, 1);
        _presenceRepository.addPresence(2, 1, 7, "2022-11-12", "2022-11-15", 1, 1);
        _presenceRepository.addPresence(2, 1, 8, "2022-11-19", "2022-11-22", 1, 1);

        _presenceRepository.addPresence(2, 2, 1, "2022-10-02", "2022-10-04", 1, 1);
        _presenceRepository.addPresence(2, 2, 2, "2022-10-09", "2022-10-11", 1, 0);
        _presenceRepository.addPresence(2, 2, 3, "2022-10-16", "2022-10-18", 1, 1);
        _presenceRepository.addPresence(2, 2, 4, "2022-10-23", "2022-10-25", 1, 0);
        _presenceRepository.addPresence(2, 2, 5, "2022-10-30", "2022-11-01", 1, 1);
        _presenceRepository.addPresence(2, 2, 6, "2022-11-05", "2022-11-08", 1, 1);
        _presenceRepository.addPresence(2, 2, 7, "2022-11-12", "2022-11-15", 1, 1);
        _presenceRepository.addPresence(2, 2, 8, "2022-11-19", "2022-11-22", 1, 1);

        BindingContext = this;
    }

    private async void LoginClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new Login();
    }
}

