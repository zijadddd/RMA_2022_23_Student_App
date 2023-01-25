using Org.Json;
using RMA_2022_23_Student_App.Data;
using RMA_2022_23_Student_App.Models;
using System.Text.Json;
using ZXing.Net.Maui;

namespace RMA_2022_23_Student_App;

public partial class QRScanner : ContentPage
{
    private PresenceRepository _presenceRepository;
	public QRScanner()
	{
		InitializeComponent();
        _presenceRepository = new PresenceRepository();
	}

    private void CameraBarcodeReaderView_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        Dispatcher.Dispatch(() =>
        { 
            Presence presence = JsonSerializer.Deserialize<Presence>($"{e.Results[0].Value}");
            if (presence.lectureDate == "null") presence.lectureDate = null;
            if (presence.exerciseDate == "null") presence.exerciseDate = null;
            _presenceRepository.addPresence(TabbeddPage.student.studentId, presence.subjectId, presence.lectureDate, presence.exerciseDate, presence.lecturePresence, presence.exercisePresence);
            barcode.Text = $"{e.Results[0].Value}";
        });
    }
}