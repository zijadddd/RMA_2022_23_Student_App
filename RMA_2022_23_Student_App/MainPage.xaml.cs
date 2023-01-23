using RMA_2022_23_Student_App.Data;
using System.Windows.Input;

namespace RMA_2022_23_Student_App;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
        StudentRepository _studentRepository = new StudentRepository();
        SubjectRepository _subjectRepository = new SubjectRepository();

        _studentRepository.AddNewStudent("Zijad", "Doglod", "11.10.2001", "Zenica", "060 324 0384", "zijad@gmail.com", "123456", "185", "UNZE", "PTF", "SI", "Ja sam Zijad Doglod i dolazim iz mjesta zvano Tetovo u blizini Zenice.", "people1.jpg");
        _studentRepository.AddNewStudent("Muhamed", "Haseljic", "23.05.2001", "Vjetrenice", "060 555 4444", "muhamed@gmail.com", "654321", "185", "UNZE", "PTF", "SI", "Ja sam Muhamed Haseljic i ne dajem puno informacija o sebi.", "people4.jpg");

        _subjectRepository.addNewSubject("Razvoj mobilnih aplikacija", "Esad Kadušić", "socialmedia.png", "#cde7fc", "#AA3e8dfd");
        _subjectRepository.addNewSubject("Web programiranje", "Đulaga Hadžić", "subjectone.png", "#e6ceff", "#AAd078ff");
        _subjectRepository.addNewSubject("Uvod u tehnike programiranja", "Adnan Dželihođić", "socialmedia.png", "#cde7fc", "#AA3e8dfd");
        BindingContext = this;
    }

    private async void LoginClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Login());
    }
    private async void RegistrationClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Registration());
    }
}

