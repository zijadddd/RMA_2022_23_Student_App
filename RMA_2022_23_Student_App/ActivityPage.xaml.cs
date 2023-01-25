using RMA_2022_23_Student_App.Data;
using RMA_2022_23_Student_App.Models;

namespace RMA_2022_23_Student_App;

public partial class ActivityPage : ContentPage
{
    private PresenceRepository _presenceRepository;
	public ActivityPage(int subjectId)
    {
        InitializeComponent();

        _presenceRepository = new PresenceRepository();
        List<Presence> presences = _presenceRepository.GetAllPresence(TabbeddPage.student.studentId, subjectId);
        if (presences.ElementAtOrDefault(0) != null)
        {
            if (!string.IsNullOrEmpty(presences[0].lectureDate))
            {
                if (presences[0].lecturePresence == 1) weekLecture1.Text = "Lectures (" + presences[0].lectureDate + "): +";
                else weekLecture1.Text = "Lectures (" + presences[0].lectureDate + "): -";
                weekSeparator1.Color = Colors.Gray;
            }
            if (!string.IsNullOrEmpty(presences[0].exerciseDate))
            {
                if (presences[0].exercisePresence == 1) weekExercise1.Text = "Exercises (" + presences[0].exerciseDate + "): +";
                else weekExercise1.Text = "Exercises (" + presences[0].exerciseDate + "): -";
                weekSeparator1.Color = Colors.Gray;
            }
        }
        if (presences.ElementAtOrDefault(1) != null)
        {
            if (!string.IsNullOrEmpty(presences[1].lectureDate))
            {
                if (presences[1].lecturePresence == 1) weekLecture2.Text = "Lectures (" + presences[1].lectureDate + "): +";
                else weekLecture2.Text = "Lectures (" + presences[0].lectureDate + "): -";
                weekSeparator2.Color = Colors.Gray;
            }
            if (!string.IsNullOrEmpty(presences[0].exerciseDate))
            {
                if (presences[1].exercisePresence == 1) weekExercise2.Text = "Exercises (" + presences[1].exerciseDate + "): +";
                else weekExercise2.Text = "Exercises (" + presences[1].exerciseDate + "): -";
                weekSeparator2.Color = Colors.Gray;
            }
        }
        if (presences.ElementAtOrDefault(2) != null)
        {
            if (!string.IsNullOrEmpty(presences[2].lectureDate))
            {
                if (presences[2].lecturePresence == 1) weekLecture3.Text = "Lectures (" + presences[2].lectureDate + "): +";
                else weekLecture3.Text = "Lectures (" + presences[2].lectureDate + "): -";
                weekSeparator3.Color = Colors.Gray;
            }
            if (!string.IsNullOrEmpty(presences[2].exerciseDate))
            {
                if (presences[2].exercisePresence == 1) weekExercise3.Text = "Exercises (" + presences[2].exerciseDate + "): +";
                else weekExercise3.Text = "Exercises (" + presences[2].exerciseDate + "): -";
                weekSeparator3.Color = Colors.Gray;
            }
        }
        if (presences.ElementAtOrDefault(3) != null)
        {
            if (!string.IsNullOrEmpty(presences[3].lectureDate))
            {
                if (presences[3].lecturePresence == 1) weekLecture4.Text = "Lectures (" + presences[3].lectureDate + "): +";
                else weekLecture4.Text = "Lectures (" + presences[3].lectureDate + "): -";
                weekSeparator4.Color = Colors.Gray;
            }
            if (!string.IsNullOrEmpty(presences[3].exerciseDate))
            {
                if (presences[3].exercisePresence == 1) weekExercise4.Text = "Exercises (" + presences[3].exerciseDate + "): +";
                else weekExercise4.Text = "Exercises (" + presences[3].exerciseDate + "): -";
                weekSeparator4.Color = Colors.Gray;
            }
        }
        if (presences.ElementAtOrDefault(4) != null)
        {
            if (!string.IsNullOrEmpty(presences[4].lectureDate))
            {
                if (presences[4].lecturePresence == 1) weekLecture5.Text = "Lectures (" + presences[4].lectureDate + "): +";
                else weekLecture5.Text = "Lectures (" + presences[4].lectureDate + "): -";
                weekSeparator5.Color = Colors.Gray;
            }
            if (!string.IsNullOrEmpty(presences[4].exerciseDate))
            {
                if (presences[4].exercisePresence == 1) weekExercise5.Text = "Exercises (" + presences[4].exerciseDate + "): +";
                else weekExercise5.Text = "Exercises (" + presences[4].exerciseDate + "): -";
                weekSeparator5.Color = Colors.Gray;
            }
        }
        if (presences.ElementAtOrDefault(5) != null)
        {
            if (!string.IsNullOrEmpty(presences[5].lectureDate))
            {
                if (presences[5].lecturePresence == 1) weekLecture6.Text = "Lectures (" + presences[5].lectureDate + "): +";
                else weekLecture6.Text = "Lectures (" + presences[5].lectureDate + "): -";
                weekSeparator6.Color = Colors.Gray;
            }
            if (!string.IsNullOrEmpty(presences[5].exerciseDate))
            {
                if (presences[5].exercisePresence == 1) weekExercise6.Text = "Exercises (" + presences[5].exerciseDate + "): +";
                else weekExercise6.Text = "Exercises (" + presences[5].exerciseDate + "): -";
                weekSeparator6.Color = Colors.Gray;
            }
        }
        if (presences.ElementAtOrDefault(6) != null)
        {
            if (!string.IsNullOrEmpty(presences[6].lectureDate))
            {
                if (presences[6].lecturePresence == 1) weekLecture7.Text = "Lectures (" + presences[6].lectureDate + "): +";
                else weekLecture7.Text = "Lectures (" + presences[6].lectureDate + "): -";
                weekSeparator7.Color = Colors.Gray;
            }
            if (!string.IsNullOrEmpty(presences[6].exerciseDate))
            {
                if (presences[6].exercisePresence == 1) weekExercise7.Text = "Exercises (" + presences[6].exerciseDate + "): +";
                else weekExercise7.Text = "Exercises (" + presences[6].exerciseDate + "): -";
                weekSeparator7.Color = Colors.Gray;
            }
        }
        if (presences.ElementAtOrDefault(7) != null)
        {
            if (!string.IsNullOrEmpty(presences[7].lectureDate))
            {
                if (presences[7].lecturePresence == 1) weekLecture8.Text = "Lectures (" + presences[7].lectureDate + "): +";
                else weekLecture8.Text = "Lectures (" + presences[7].lectureDate + "): -";
                weekSeparator8.Color = Colors.Gray;
            }
            if (!string.IsNullOrEmpty(presences[7].exerciseDate))
            {
                if (presences[7].exercisePresence == 1) weekExercise8.Text = "Exercises (" + presences[7].exerciseDate + "): +";
                else weekExercise8.Text = "Exercises (" + presences[7].exerciseDate + "): -";
                weekSeparator8.Color = Colors.Gray;
            }
        }
        if (presences.ElementAtOrDefault(8) != null)
        {
            if (!string.IsNullOrEmpty(presences[8].lectureDate))
            {
                if (presences[8].lecturePresence == 1) weekLecture9.Text = "Lectures (" + presences[8].lectureDate + "): +";
                else weekLecture9.Text = "Lectures (" + presences[8].lectureDate + "): -";
                weekSeparator9.Color = Colors.Gray;
            }
            if (!string.IsNullOrEmpty(presences[8].exerciseDate))
            {
                if (presences[8].exercisePresence == 1) weekExercise9.Text = "Exercises (" + presences[8].exerciseDate + "): +";
                else weekExercise9.Text = "Exercises (" + presences[8].exerciseDate + "): -";
                weekSeparator9.Color = Colors.Gray;
            }
        }
        if (presences.ElementAtOrDefault(9) != null)
        {
            if (!string.IsNullOrEmpty(presences[9].lectureDate))
            {
                if (presences[9].lecturePresence == 1) weekLecture10.Text = "Lectures (" + presences[9].lectureDate + "): +";
                else weekLecture10.Text = "Lectures (" + presences[9].lectureDate + "): -";
                weekSeparator10.Color = Colors.Gray;
            }
            if (!string.IsNullOrEmpty(presences[9].exerciseDate))
            {
                if (presences[9].exercisePresence == 1) weekExercise10.Text = "Exercises (" + presences[9].exerciseDate + "): +";
                else weekExercise10.Text = "Exercises (" + presences[9].exerciseDate + "): -";
                weekSeparator10.Color = Colors.Gray;
            }
        }
        if (presences.ElementAtOrDefault(10) != null)
        {
            if (!string.IsNullOrEmpty(presences[10].lectureDate))
            {
                if (presences[10].lecturePresence == 1) weekLecture11.Text = "Lectures (" + presences[10].lectureDate + "): +";
                else weekLecture11.Text = "Lectures (" + presences[10].lectureDate + "): -";
                weekSeparator11.Color = Colors.Gray;
            }
            if (!string.IsNullOrEmpty(presences[10].exerciseDate))
            {
                if (presences[10].exercisePresence == 1) weekExercise11.Text = "Exercises (" + presences[10].exerciseDate + "): +";
                else weekExercise11.Text = "Exercises (" + presences[10].exerciseDate + "): -";
                weekSeparator11.Color = Colors.Gray;
            }
        }
        if (presences.ElementAtOrDefault(11) != null)
        {
            if (!string.IsNullOrEmpty(presences[11].lectureDate))
            {
                if (presences[11].lecturePresence == 1) weekLecture12.Text = "Lectures (" + presences[11].lectureDate + "): +";
                else weekLecture12.Text = "Lectures (" + presences[11].lectureDate + "): -";
                weekSeparator12.Color = Colors.Gray;
            }
            if (!string.IsNullOrEmpty(presences[11].exerciseDate))
            {
                if (presences[11].exercisePresence == 1) weekExercise12.Text = "Exercises (" + presences[11].exerciseDate + "): +";
                else weekExercise12.Text = "Exercises (" + presences[11].exerciseDate + "): -";
                weekSeparator12.Color = Colors.Gray;
            }
        }
        if (presences.ElementAtOrDefault(12) != null)
        {
            if (!string.IsNullOrEmpty(presences[12].lectureDate))
            {
                if (presences[12].lecturePresence == 1) weekLecture13.Text = "Lectures (" + presences[12].lectureDate + "): +";
                else weekLecture13.Text = "Lectures (" + presences[12].lectureDate + "): -";
                weekSeparator13.Color = Colors.Gray;
            }
            if (!string.IsNullOrEmpty(presences[0].exerciseDate))
            {
                if (presences[12].exercisePresence == 1) weekExercise13.Text = "Exercises (" + presences[12].exerciseDate + "): +";
                else weekExercise13.Text = "Exercises (" + presences[12].exerciseDate + "): -";
                weekSeparator13.Color = Colors.Gray;
            }
        }
        if (presences.ElementAtOrDefault(13) != null)
        {
            if (!string.IsNullOrEmpty(presences[13].lectureDate))
            {
                if (presences[13].lecturePresence == 1) weekLecture14.Text = "Lectures (" + presences[13].lectureDate + "): +";
                else weekLecture14.Text = "Lectures (" + presences[13].lectureDate + "): -";
                weekSeparator14.Color = Colors.Gray;
            }
            if (!string.IsNullOrEmpty(presences[13].exerciseDate))
            {
                if (presences[13].exercisePresence == 1) weekExercise14.Text = "Exercises (" + presences[13].exerciseDate + "): +";
                else weekExercise14.Text = "Exercises (" + presences[13].exerciseDate + "): -";
                weekSeparator14.Color = Colors.Gray;
            }
        }
        if (presences.ElementAtOrDefault(14) != null)
        {
            if (!string.IsNullOrEmpty(presences[14].lectureDate))
            {
                if (presences[14].lecturePresence == 1) weekLecture15.Text = "Lectures (" + presences[14].lectureDate + "): +";
                else weekLecture15.Text = "Lectures (" + presences[14].lectureDate + "): -";
                weekSeparator15.Color = Colors.Gray;
            }
            if (!string.IsNullOrEmpty(presences[14].exerciseDate))
            {
                if (presences[14].exercisePresence == 1) weekExercise15.Text = "Exercises (" + presences[14].exerciseDate + "): +";
                else weekExercise15.Text = "Exercises (" + presences[14].exerciseDate + "): -";
                weekSeparator15.Color = Colors.Gray;
            }
        }
        if (presences.ElementAtOrDefault(15) != null)
        {
            if (!string.IsNullOrEmpty(presences[15].lectureDate))
            {
                if (presences[15].lecturePresence == 1) weekLecture16.Text = "Lectures (" + presences[15].lectureDate + "): +";
                else weekLecture16.Text = "Lectures (" + presences[15].lectureDate + "): -";
                weekSeparator16.Color = Colors.Gray;
            }
            if (!string.IsNullOrEmpty(presences[0].exerciseDate))
            {
                if (presences[15].exercisePresence == 1) weekExercise16.Text = "Exercises (" + presences[15].exerciseDate + "): +";
                else weekExercise16.Text = "Exercises (" + presences[15].exerciseDate + "): -";
                weekSeparator16.Color = Colors.Gray;
            }
        }
    }
}