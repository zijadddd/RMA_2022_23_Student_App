namespace RMA_2022_23_Student_App;

public partial class ProfilePage : ContentPage
{
	public ProfilePage()
	{
		InitializeComponent();

		BindingContext = this;

		String temp = "";
		String[] dates = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
		DateTimeOffset todayDate = DateTimeOffset.Now;
		temp += dates[todayDate.Month - 1] + " " + todayDate.Day;
		if (todayDate.Day%10 == 1 && todayDate.Day != 11) temp += "st";
		else if (todayDate.Day%10 == 2 && todayDate.Day != 12) temp += "nd";
		else if (todayDate.Day%10 == 3 && todayDate.Day != 13) temp += "rd";
		else temp += "th";
		date.Text = temp;
	}
}