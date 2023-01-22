using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using RMA_2022_23_Student_App.Data;

namespace RMA_2022_23_Student_App;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("CursorColor", (handler, view) =>
        {
            #if __ANDROID__
                handler.PlatformView.TextCursorDrawable.SetTint(Color.Parse("#0067ff").ToAndroid());
            #endif
            Application.Current.UserAppTheme = AppTheme.Light;
        });



        MainPage = new AppShell();
	}
}
