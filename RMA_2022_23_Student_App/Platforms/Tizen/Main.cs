using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace RMA_2022_23_Student_App;

class Program : MauiApplication
{
	protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
