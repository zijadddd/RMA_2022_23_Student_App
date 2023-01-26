using Newtonsoft.Json.Linq;
using RMA_2022_23_Student_App.Data;
using RMA_2022_23_Student_App.Models;
using System.Text.Json;

namespace RMA_2022_23_Student_App;

public partial class QRScanner : ContentPage
{
    private PresenceRepository _presenceRepository;
    private StudentSubjectRepository _studentSubjectRepository;
	public QRScanner()
	{
		InitializeComponent();
        _presenceRepository = new PresenceRepository();
        _studentSubjectRepository = new StudentSubjectRepository();
	}

    private void CameraBarcodeReaderView_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        Dispatcher.Dispatch(() =>
        {
            JObject jsonObject = JObject.Parse($"{e.Results[0].Value}");
            PresenceModel presence = new PresenceModel(jsonObject.GetValue("subjectId").ToString(), jsonObject.GetValue("week").ToString(), jsonObject.GetValue("lectureDate").ToString(), jsonObject.GetValue("exerciseDate").ToString());
            if (int.Parse(presence.week) < 1 || int.Parse(presence.week) > 16) barcode.Text = "Week value must be between 1-16.";
            else
            {
                if (presence.lectureDate == "null" && presence.exerciseDate != "null") _presenceRepository.addExercisePresence(TabbeddPage.student.studentId, int.Parse(presence.subjectId), int.Parse(presence.week), presence.lectureDate, presence.exerciseDate, 0, 1);
                if (presence.lectureDate != "null" && presence.exerciseDate == "null") _presenceRepository.addLecturePresence(TabbeddPage.student.studentId, int.Parse(presence.subjectId), int.Parse(presence.week), presence.lectureDate, presence.exerciseDate, 1, 0);
                barcode.Text = "Your evidence have been recorded for today.";
            }
        });
    }
}