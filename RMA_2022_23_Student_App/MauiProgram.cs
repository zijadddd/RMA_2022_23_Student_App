using RMA_2022_23_Student_App.Data;

namespace RMA_2022_23_Student_App;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Montserrat-Light.ttf", "MontserratLight");
				fonts.AddFont("Montserrat-Medium.ttf", "MontserratMedium");
				fonts.AddFont("MaterialIcons.ttf", "MaterialIcons");
			});
			builder.Services.AddSingleton<PresenceRepository>();
			builder.Services.AddSingleton<StudentRepository>();
			builder.Services.AddSingleton<StudentSubjectRepository>();
			builder.Services.AddSingleton<SubjectRepository>();
        return builder.Build();
	}
}
