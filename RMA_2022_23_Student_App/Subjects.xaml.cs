using RMA_2022_23_Student_App.Data;
using RMA_2022_23_Student_App.Models;

namespace RMA_2022_23_Student_App;

public partial class Subjects : ContentPage
{

	private bool isTappedActiveSubjects = true;
	private bool isTappedPendingSubjects = false;
	private bool isTappedCompletedSubjects = false;
    public IList<Subject> subjectList { get; set; }

    public Subjects()
    {
        InitializeComponent();

        BindingContext = this;

        ActiveSubjects.Shadow.Opacity = float.Parse("0.6");
        ActiveSubjects.BackgroundColor = Color.FromRgb(0, 103, 255);
        ActiveSubjectsNumber.TextColor = Color.FromRgb(255, 255, 255);
        ActiveSubjectsText.TextColor = Color.FromRgb(255, 255, 255);
        ActiveSubjectsText.Opacity = 0.6;

        studentFullName.Text = TabbeddPage.student.firstName;
        studentProfilePhoto.Source = TabbeddPage.student.profilePhotoUrl;

        String temp = "";
        String[] dates = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        DateTimeOffset todayDate = DateTimeOffset.Now;
        temp += dates[todayDate.Month - 1] + " " + todayDate.Day;
        if (todayDate.Day % 10 == 1 && todayDate.Day != 11) temp += "st";
        else if (todayDate.Day % 10 == 2 && todayDate.Day != 12) temp += "nd";
        else if (todayDate.Day % 10 == 3 && todayDate.Day != 13) temp += "rd";
        else temp += "th";
        date.Text = temp;

        SubjectRepository _subjectRepository = new SubjectRepository();
        listView.ItemsSource = _subjectRepository.GetAllSubjects();     
    }

    private async void ClassPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new ClassPage());
    }

    void OnActiveSubjectsTapped(object sender, EventArgs e)
    {
		if(this.isTappedActiveSubjects == false)
		{
            ActiveSubjects.Shadow.Opacity = float.Parse("0.6");
            ActiveSubjects.BackgroundColor = Color.FromRgb(0, 103, 255);
            ActiveSubjectsNumber.TextColor = Color.FromRgb(255, 255, 255);
            ActiveSubjectsText.TextColor = Color.FromRgb(255, 255, 255);
            ActiveSubjectsText.Opacity = 0.6;
            this.isTappedActiveSubjects = true;
        }
        if (this.isTappedPendingSubjects == true)
        {
            PendingSubjects.Shadow.Opacity = 0;
            PendingSubjects.BackgroundColor = Colors.Transparent;
            PendingSubjectsNumber.TextColor = Color.FromRgb(36, 37, 61);
            PendingSubjectsText.TextColor = Color.FromRgb(36, 37, 61);
            PendingSubjectsText.Opacity = 0.3;
            this.isTappedPendingSubjects = false;
            return;
        }
        if (this.isTappedCompletedSubjects == true)
        {
            CompletedSubjects.Shadow.Opacity = 0;
            CompletedSubjects.BackgroundColor = Colors.Transparent;
            CompletedSubjectsNumber.TextColor = Color.FromRgb(36, 37, 61);
            CompletedSubjectsText.TextColor = Color.FromRgb(36, 37, 61);
            CompletedSubjectsText.Opacity = 0.3;
            this.isTappedCompletedSubjects = false;
            return;
        }
    }

    void OnPendingSubjectsTapped(object sender, EventArgs e)
    {
        if (this.isTappedPendingSubjects == false)
        {
            PendingSubjects.Shadow.Opacity = float.Parse("0.6");
            PendingSubjects.BackgroundColor = Color.FromRgb(0, 103, 255);
            PendingSubjectsNumber.TextColor = Color.FromRgb(255, 255, 255);
            PendingSubjectsText.TextColor = Color.FromRgb(255, 255, 255);
            PendingSubjectsText.Opacity = 0.6;
            this.isTappedPendingSubjects = true;
            if (this.isTappedActiveSubjects == true)
            {
                ActiveSubjects.Shadow.Opacity = 0;
                ActiveSubjects.BackgroundColor = Colors.Transparent;
                ActiveSubjectsNumber.TextColor = Color.FromRgb(36, 37, 61);
                ActiveSubjectsText.TextColor = Color.FromRgb(36, 37, 61);
                ActiveSubjectsText.Opacity = 0.3;
                this.isTappedActiveSubjects = false;
                return;
            }
            if (this.isTappedCompletedSubjects == true)
            {
                CompletedSubjects.Shadow.Opacity = 0;
                CompletedSubjects.BackgroundColor = Colors.Transparent;
                CompletedSubjectsNumber.TextColor = Color.FromRgb(36, 37, 61);
                CompletedSubjectsText.TextColor = Color.FromRgb(36, 37, 61);
                CompletedSubjectsText.Opacity = 0.3;
                this.isTappedCompletedSubjects = false;
                return;
            }
        }
    }

    void OnCompletedSubjectsTapped(object sender, EventArgs e)
    {
        if (this.isTappedCompletedSubjects == false)
        {
            CompletedSubjects.Shadow.Opacity = float.Parse("0.6");
            CompletedSubjects.BackgroundColor = Color.FromRgb(0, 103, 255);
            CompletedSubjectsNumber.TextColor = Color.FromRgb(255, 255, 255);
            CompletedSubjectsText.TextColor = Color.FromRgb(255, 255, 255);
            CompletedSubjectsText.Opacity = 0.6;
            this.isTappedCompletedSubjects = true;
        }
        if (this.isTappedActiveSubjects == true)
        {
            ActiveSubjects.Shadow.Opacity = 0;
            ActiveSubjects.BackgroundColor = Colors.Transparent;
            ActiveSubjectsNumber.TextColor = Color.FromRgb(36, 37, 61);
            ActiveSubjectsText.TextColor = Color.FromRgb(36, 37, 61);
            ActiveSubjectsText.Opacity = 0.3;
            this.isTappedActiveSubjects = false;
            return;
        }
        if (this.isTappedPendingSubjects == true)
        {
            PendingSubjects.Shadow.Opacity = 0;
            PendingSubjects.BackgroundColor = Colors.Transparent;
            PendingSubjectsNumber.TextColor = Color.FromRgb(36, 37, 61);
            PendingSubjectsText.TextColor = Color.FromRgb(36, 37, 61);
            PendingSubjectsText.Opacity = 0.3;
            this.isTappedPendingSubjects = false;
            return;
        }
    }
}