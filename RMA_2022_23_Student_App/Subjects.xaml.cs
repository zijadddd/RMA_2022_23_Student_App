//using Microsoft.Maui;
//using Microsoft.Maui.Controls;
//using Microsoft.Maui.Controls.Shapes;
//using Microsoft.Maui.Graphics;

namespace RMA_2022_23_Student_App;

public partial class Subjects : ContentPage
{

	private bool isTappedActiveSubjects = true;
	private bool isTappedPendingSubjects = false;
	private bool isTappedCompletedSubjects = false;

    public Subjects()
    {
        InitializeComponent();

        BindingContext = this;

        ActiveSubjects.Shadow.Opacity = float.Parse("0.6");
        ActiveSubjects.BackgroundColor = Color.FromRgb(0, 103, 255);
        ActiveSubjectsNumber.TextColor = Color.FromRgb(255, 255, 255);
        ActiveSubjectsText.TextColor = Color.FromRgb(255, 255, 255);
        ActiveSubjectsText.Opacity = 0.6;

        String temp = "";
        String[] dates = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
        DateTimeOffset todayDate = DateTimeOffset.Now;
        temp += dates[todayDate.Month - 1] + " " + todayDate.Day;
        if (todayDate.Day % 10 == 1 && todayDate.Day != 11) temp += "st";
        else if (todayDate.Day % 10 == 2 && todayDate.Day != 12) temp += "nd";
        else if (todayDate.Day % 10 == 3 && todayDate.Day != 13) temp += "rd";
        else temp += "th";
        date.Text = temp;
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

/*            Frame frame = new Frame
            {
                Padding = 0,
                HeightRequest = 295,
                BackgroundColor = Color.FromRgb(37, 150, 190),
                BorderColor = Colors.Transparent,
                CornerRadius = 40,
                Content = new VerticalStackLayout
                {
                    Children =
                    {
                        new Frame
                        {
                            Margin = new Thickness(0, 10, 0, 10),
                            WidthRequest = double.Parse("350"),
                            HeightRequest = double.Parse("280"),
                            CornerRadius = float.Parse("30"),
                            BackgroundColor = Colors.Transparent,
                            BorderColor = Colors.Transparent,
                            Content = new Image
                            {
                                Source = ImageSource.FromFile("socialmedia.png"),
                                Aspect = Aspect.AspectFill
                            }
                        },
                        new Frame
                        {
                            Margin = new Thickness(0, -290, 13, 30),
                            BorderColor = Colors.Transparent,
                            CornerRadius = float.Parse("30"),
                            WidthRequest = double.Parse("80"),
                            HeightRequest = double.Parse("100"),
                            HorizontalOptions = LayoutOptions.End,
                            Content = new VerticalStackLayout
                            {
                                VerticalOptions = LayoutOptions.Center,
                                WidthRequest = double.Parse("80"),
                                HeightRequest = double.Parse("80"),
                                Children =
                                {
                                    new Label
                                    {
                                        Text = "12",
                                        TextColor = Color.FromRgb(35, 36, 58),
                                        FontSize = double.Parse("45"),
                                        FontFamily = "MontserratMedium",
                                        FontAttributes = FontAttributes.Bold,
                                        HorizontalOptions = LayoutOptions.Center
                                    },
                                    new Label
                                    {
                                        Text = "Students",
                                        TextColor = Color.FromRgb(35, 36, 58),
                                        FontSize = double.Parse("10"),
                                        FontFamily = "MontserratMedium",
                                        FontAttributes = FontAttributes.Bold,
                                        HorizontalOptions = LayoutOptions.Center
                                    }
                                }
                            }
                        },
                        new Frame
                        {
                            Padding = new Thickness(20, 20, 20, 0),
                            HeightRequest = double.Parse("145"),
                            Margin = new Thickness(10, 0, 10, 10),
                            CornerRadius = float.Parse("40"),
                            BorderColor = Colors.Transparent,
                            BackgroundColor = Color.FromRgba("#AA3e8dfd"),
                            VerticalOptions = LayoutOptions.End,
                            Content = new VerticalStackLayout
                            {
                                Spacing = 5,
                                Children =
                                {
                                    new Label
                                    {
                                        Text = "Razvoj mobilnih aplikacija",
                                        FontFamily = "MontserratMedium",
                                        TextColor = Colors.White,
                                        FontSize = 20,
                                        FontAttributes = FontAttributes.Bold
                                    },
                                    new Label
                                    {
                                        Text = "Esad Kadušiæ",
                                        FontFamily = "MontserratMedium",
                                        TextColor = Colors.White,
                                        FontSize = 15
                                    },
                                    new Button
                                    {
                                        // FontAttributes="Bold" FontFamily="MontserratMedium" HorizontalOptions="End" Clicked="ClassPageClicked" TextColor="White"/>
                                        Text = "Enter",
                                        BackgroundColor = Colors.Transparent,
                                        BorderColor = Colors.White,
                                        BorderWidth = 1,
                                        WidthRequest = double.Parse("100"),
                                        CornerRadius = int.Parse("20"),
                                        Padding = new Thickness(15),
                                        FontAttributes = FontAttributes.Bold,
                                        FontFamily = "MontserratMedium",
                                        HorizontalOptions = LayoutOptions.End,
                                        TextColor = Colors.White
                                    }
                                }
                            }
                        }
                    }
                }
            };
            Subjects.ChildAdded += frame; */
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