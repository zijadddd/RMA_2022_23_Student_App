using RMA_2022_23_Student_App.Models;
using SQLite;

namespace RMA_2022_23_Student_App;

public partial class Login : ContentPage
{
    private SQLiteAsyncConnection _connection;
    public Login()
	{
		InitializeComponent();
        _connection = new SQLiteAsyncConnection(Data.Database.DatabasePath, Data.Database.Flags);
        LoginButton.Clicked += LoginClicked;
    }

    private async void LoginClicked(object sender, EventArgs e)
    {
        try
        {
            var query = _connection.Table<Student>().Where(s => s.email == email.Text);
            Student student = await query.FirstOrDefaultAsync();

            if (student != null)
            {
                if (student.password == password.Text)
                {
                    TabbeddPage.student = student;
                    Application.Current.MainPage = new TabbeddPage();
                } 
                else await DisplayAlert("Error", "Incorrect password", "Ok");
            } else await DisplayAlert("Error", "User with this email does not exist!", "Ok");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", ex.Message, "OK");
        }
    }

    private async void RegistrationClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Registration());
    }

}